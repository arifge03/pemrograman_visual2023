<?php
require_once 'database.php';

class SewaKamar 
{
    private $db;
    private $table = 'sewa_kamar';

    public $id_sewa = 0;
    public $id_kamar = 0;
    public $id_penyewa = 0;
    public $tanggal_checkin = '';
    public $tanggal_checkout = '';
    public $jumlah_malam = 0;
    public $total_biaya = 0.00;

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

    public function get_by_id(int $id_sewa)
    {
        $query = "SELECT * FROM $this->table WHERE id_sewa = $id_sewa";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function get_by_kodemk(string $nama_kamar)
    {
        $query = "SELECT * FROM $this->table 
                  JOIN kamar ON sewa_kamar.id_kamar = kamar.id_kamar 
                  WHERE kamar.nama_kamar = '$nama_kamar'";
        $result_set = $this->db->query($query);   
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (id_kamar, id_penyewa, tanggal_checkin, tanggal_checkout, jumlah_malam, total_biaya) 
        VALUES ('$this->id_kamar', '$this->id_penyewa', '$this->tanggal_checkin', '$this->tanggal_checkout', '$this->jumlah_malam', '$this->total_biaya')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update(int $id_sewa): int
    {
        $query = "UPDATE $this->table SET id_kamar = '$this->id_kamar', id_penyewa = '$this->id_penyewa', 
        tanggal_checkin = '$this->tanggal_checkin', tanggal_checkout = '$this->tanggal_checkout', 
        jumlah_malam = '$this->jumlah_malam', total_biaya = '$this->total_biaya' 
        WHERE id_sewa = $id_sewa";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete(int $id_sewa): int
    {
        $query = "DELETE FROM $this->table WHERE id_sewa = $id_sewa";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>
