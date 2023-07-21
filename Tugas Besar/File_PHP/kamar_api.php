<?php
require_once 'database.php';
require_once 'Kamar.php';
$db = new MySQLDatabase();
$kamar = new Kamar($db);

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id_kamar'])) {
            $id_kamar = $_GET['id_kamar'];
        }
        if (isset($_GET['nama_kamar'])) {
            $nama_kamar = $_GET['nama_kamar'];
        }
        if ($id_kamar > 0) {
            $result = $kamar->get_by_id($id_kamar);
        } elseif ($nama_kamar != "") {
            $result = $kamar->get_by_kodemk($nama_kamar);
        } else {
            $result = $kamar->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new kamar
        $kamar->nama_kamar = $_POST['nama_kamar'];
        $kamar->jenis_kamar = $_POST['jenis_kamar'];
        $kamar->harga = $_POST['harga'];

        $kamar->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Kamar created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Kamar not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'PUT':
        // Update an existing data
        $_PUT = [];
        parse_str(file_get_contents("php://input"), $_PUT);
        $kamar->nama_kamar = $_PUT['nama_kamar'];
        $kamar->jenis_kamar = $_PUT['jenis_kamar'];
        $kamar->harga = $_PUT['harga'];

        $a = $kamar->update_by_kodemk($kamar->nama_kamar);
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Kamar updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Kamar update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a user
        if (isset($_GET['id_kamar'])) {
            $id_kamar = $_GET['id_kamar'];
        }
        if (isset($_GET['nama_kamar'])) {
            $nama_kamar = $_GET['nama_kamar'];
        }
        if ($id_kamar > 0) {
            $kamar->delete($id_kamar);
        } elseif ($nama_kamar != "") {
            $kamar->delete_by_kodemk($nama_kamar);
        } else {
            // Handle delete request without id_kamar or nama_kamar
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Kamar deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Kamar delete failed.';
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
