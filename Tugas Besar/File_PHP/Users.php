<?php
//Simpanlah dengan nama file : Users.php
require_once 'database1.php';
class Users 
{
    private $db;
    private $table = 'users';
    public $username = "";
    public $passwd = "";
    public $rolename = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    
    public function login($uname,$pwd){
        $passwd = MD5($pwd);
        $query = "SELECT * FROM $this->table WHERE username = '{$uname}' and passwd='{$passwd}'";
        $hasil = $this->db->query($query);   
        $data =  $this->db->fetch($hasil);
                
        if($this->db->affected_rows()>0){
            return $data['rolename'];
        } else {
            return null;
        } 
    }
    
}
?>