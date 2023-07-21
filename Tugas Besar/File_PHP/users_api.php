<?php
require_once 'database1.php';
require_once 'Users.php';
$db = new MySQLDatabase();
$users = new Users($db);
$id=0;
$username=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'POST':
        // Add a new users
        $users->username = $_POST['username'];
        $users->passwd = $_POST['passwd'];
               
        $v = $users->login($users->username,$users->passwd);      
        
        if($v!=null){
            $data['status']='success';
            $data['message']=$v;
        } else {
            $data['status']='failed';
            $data['message']='Login is not valid';
        }
        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>
