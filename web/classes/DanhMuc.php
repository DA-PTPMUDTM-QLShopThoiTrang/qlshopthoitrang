<?php
include_once(__DIR__ . '/Database.php');
class DanhMuc
{
    private $db;

    public function __construct()
    {
        $this->db = new Database();
    }
    public function layDanhMuc()
    {
        return $this->db->selectNonParam("select * from danhmuc");
    }
}
