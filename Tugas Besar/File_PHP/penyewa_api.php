<?php
require_once 'database.php';
require_once 'Penyewa.php';
$db = new MySQLDatabase();
$penyewa = new Penyewa($db);

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id_penyewa'])) {
            $id_penyewa = $_GET['id_penyewa'];
        }
        if (isset($_GET['nama_penyewa'])) {
            $nama_penyewa = $_GET['nama_penyewa'];
        }
        if ($id_penyewa > 0) {
            $result = $penyewa->get_by_id($id_penyewa);
        } elseif ($nama_penyewa != "") {
            $result = $penyewa->get_by_kodemk($nama_penyewa);
        } else {
            $result = $penyewa->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new penyewa
        $penyewa->nama_penyewa = $_POST['nama_penyewa'];
        $penyewa->telepon = $_POST['telepon'];
        $penyewa->id_kamar = $_POST['id_kamar'];
        $penyewa->harga = $_POST['harga'];
        $penyewa->tanggal_checkin = $_POST['tanggal_checkin'];
        $penyewa->tanggal_checkout = $_POST['tanggal_checkout'];
        $penyewa->jumlah_malam = $_POST['jumlah_malam'];
        $penyewa->total_biaya = $_POST['total_biaya'];

        $penyewa->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Penyewa created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Penyewa not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'PUT':
        // Update an existing data
        $_PUT = [];
        parse_str(file_get_contents("php://input"), $_PUT);
        $penyewa->nama_penyewa = $_PUT['nama_penyewa'];
        $penyewa->telepon = $_PUT['telepon'];
        $penyewa->id_kamar = $_PUT['id_kamar'];
        $penyewa->harga = $_PUT['harga'];
        $penyewa->tanggal_checkin = $_PUT['tanggal_checkin'];
        $penyewa->tanggal_checkout = $_PUT['tanggal_checkout'];
        $penyewa->jumlah_malam = $_PUT['jumlah_malam'];
        $penyewa->total_biaya = $_PUT['total_biaya'];

        $a = $penyewa->update_by_kodemk($penyewa->nama_penyewa);
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Penyewa updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Penyewa update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a user
        if (isset($_GET['id_penyewa'])) {
            $id_penyewa = $_GET['id_penyewa'];
        }
        if (isset($_GET['nama_penyewa'])) {
            $nama_penyewa = $_GET['nama_penyewa'];
        }
        if ($id_penyewa > 0) {
            $penyewa->delete($id_penyewa);
        } elseif ($nama_penyewa != "") {
            $penyewa->delete_by_kodemk($nama_penyewa);
        } else {
            // Handle delete request without id_penyewa or nama_penyewa
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Penyewa deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Penyewa delete failed.';
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
