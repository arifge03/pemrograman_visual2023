<?php
//Simpanlah dengan nama file : Kamar.php
require_once 'database.php';

class Kamar 
{
    private $db;
    private $table = 'kamar';
    public $id_kamar = "";
    public $nama_kamar = "";
    public $jenis_kamar = "";
    public $harga = "";

    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }

    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function get_by_id(int $id_kamar)
    {
        $query = "SELECT * FROM $this->table WHERE id_kamar = $id_kamar";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function get_by_kodemk(string $nama_kamar)
    {
        $query = "SELECT * FROM $this->table WHERE nama_kamar = '$nama_kamar'";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nama_kamar`,`jenis_kamar`,`harga`) VALUES ('$this->nama_kamar','$this->jenis_kamar','$this->harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update(int $id_kamar): int
    {
        $query = "UPDATE $this->table SET nama_kamar = '$this->nama_kamar', jenis_kamar = '$this->jenis_kamar', harga = '$this->harga' 
        WHERE id_kamar = $id_kamar";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function update_by_kodemk(string $nama_kamar): int
    {
        $query = "UPDATE $this->table SET nama_kamar = '$this->nama_kamar', jenis_kamar = '$this->jenis_kamar', harga = '$this->harga' 
        WHERE nama_kamar = '$nama_kamar'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete(int $id_kamar): int
    {
        $query = "DELETE FROM $this->table WHERE id_kamar = $id_kamar";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_kodemk(string $nama_kamar): int
    {
        $query = "DELETE FROM $this->table WHERE nama_kamar = '$nama_kamar'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>
