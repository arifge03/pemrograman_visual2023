<?php
//Simpanlah dengan nama file : Penyewa.php
require_once 'database.php';

class Penyewa 
{
    private $db;
    private $table = 'penyewa';
    public $id_penyewa = "";
    public $nama_penyewa = "";
    public $telepon = "";
    public $id_kamar = "";
    public $harga = "";
    public $tanggal_checkin = "";
    public $tanggal_checkout = "";
    public $jumlah_malam = "";
    public $total_biaya = "";

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

    public function get_by_id(int $id_penyewa)
    {
        $query = "SELECT * FROM $this->table WHERE id_penyewa = $id_penyewa";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function get_by_kodemk(string $nama_penyewa)
    {
        $query = "SELECT * FROM $this->table WHERE nama_penyewa = '$nama_penyewa'";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nama_penyewa`,`telepon`,`id_kamar`,`harga`,`tanggal_checkin`,`tanggal_checkout`,`jumlah_malam`,`total_biaya`) VALUES ('$this->nama_penyewa','$this->telepon','$this->id_kamar','$this->harga','$this->tanggal_checkin','$this->tanggal_checkout','$this->jumlah_malam','$this->total_biaya')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update(int $id_penyewa): int
    {
        $query = "UPDATE $this->table SET nama_penyewa = '$this->nama_penyewa', telepon = '$this->telepon', id_kamar = '$this->id_kamar', harga = '$this->harga', tanggal_checkin = '$this->tanggal_checkin', tanggal_checkout = '$this->tanggal_checkout', jumlah_malam = '$this->jumlah_malam', total_biaya = '$this->total_biaya'
        WHERE id_penyewa = $id_penyewa";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function update_by_kodemk(string $nama_penyewa): int
    {
        $query = "UPDATE $this->table SET nama_penyewa = '$this->nama_penyewa', telepon = '$this->telepon', id_kamar = '$this->id_kamar', harga = '$this->harga', tanggal_checkin = '$this->tanggal_checkin', tanggal_checkout = '$this->tanggal_checkout', jumlah_malam = '$this->jumlah_malam', total_biaya = '$this->total_biaya'
        WHERE nama_penyewa = '$nama_penyewa'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete(int $id_penyewa): int
    {
        $query = "DELETE FROM $this->table WHERE id_penyewa = $id_penyewa";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_kodemk(string $nama_penyewa): int
    {
        $query = "DELETE FROM $this->table WHERE nama_penyewa = '$nama_penyewa'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>
