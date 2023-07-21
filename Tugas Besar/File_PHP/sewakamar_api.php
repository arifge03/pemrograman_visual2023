<?php
require_once 'database.php';
require_once 'SewaKamar.php';
$db = new MySQLDatabase();
$sewaKamar = new SewaKamar($db);

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id_sewa'])) {
            $id_sewa = $_GET['id_sewa'];
            $result = $sewaKamar->get_by_id($id_sewa);
        } elseif (isset($_GET['nama_kamar'])) {
            $nama_kamar = $_GET['nama_kamar'];
            $result = $sewaKamar->get_by_kodemk($nama_kamar);
        } else {
            $result = $sewaKamar->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new sewa kamar
        // Ambil data dari request body
        $data = json_decode(file_get_contents("php://input"), true);
        $sewaKamar->id_kamar = $data['id_kamar'];
        $sewaKamar->id_penyewa = $data['id_penyewa'];
        $sewaKamar->tanggal_checkin = $data['tanggal_checkin'];
        $sewaKamar->tanggal_checkout = $data['tanggal_checkout'];
        $sewaKamar->jumlah_malam = $data['jumlah_malam'];
        $sewaKamar->total_biaya = $data['total_biaya'];

        $sewaKamar->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Sewa Kamar created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Sewa Kamar not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'PUT':
        // Update an existing data
        // Ambil data dari request body
        $data = json_decode(file_get_contents("php://input"), true);
        $sewaKamar->id_sewa = $_GET['id_sewa']; // ID Sewa yang akan di-update
        $sewaKamar->id_kamar = $data['id_kamar'];
        $sewaKamar->id_penyewa = $data['id_penyewa'];
        $sewaKamar->tanggal_checkin = $data['tanggal_checkin'];
        $sewaKamar->tanggal_checkout = $data['tanggal_checkout'];
        $sewaKamar->jumlah_malam = $data['jumlah_malam'];
        $sewaKamar->total_biaya = $data['total_biaya'];

        $sewaKamar->update($sewaKamar->id_sewa);
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Sewa Kamar updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Sewa Kamar update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a data
        $id_sewa = $_GET['id_sewa'];
        $sewaKamar->delete($id_sewa);
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Sewa Kamar deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Sewa Kamar delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();
?>
