<?php
class MySQLDatabase
{
    private $conn;
    private $host = 'localhost';
    private $user = 'f0833874_appakademik';
    private $password = '12345678';
    private $database = 'f0833874_appakademik';


    public function __construct()
    {
        $this->conn = mysqli_connect($this->host, $this->user, $this->password, $this->database);
    }

    public function query($sql)
    {
        return mysqli_query($this->conn, $sql);
    }

    public function fetch_all($result)
    {
        return mysqli_fetch_assoc($result, MYSQLI_ASSOC);
    }

    public function fetch($result)
    {
        return mysqli_fetch_array($result);
    }

    public function insert_id()
    {
        return mysqli_insert_id($this->conn);
    }

    public function affected_rows()
    {
        return mysqli_affected_rows($this->conn);
    }

    public function escape_string($string)
    {
        return mysqli_real_escape_string($this->conn, $string);
    }

    public function close()
    {
        mysqli_close($this->conn);
    }

    
}
