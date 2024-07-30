<?php
include_once(__DIR__ . '/Database.php');
class GioHang
{
    private $db;

    public function __construct()
    {
        $this->db = new Database();
    }

    public function them($id, $kcid, $sl)
    {
        try {
            sqlsrv_begin_transaction($this->db->conn);
            date_default_timezone_set('Asia/Ho_Chi_Minh');
            $kt = $this->db->selectNonParam("select * from giohang where KhachHang_id = $id and KichCoSanPham_id = $kcid");

            if (count($kt) > 0) {
                //u
                $this->db->updateNonParam("UPDATE giohang SET soluong = $sl, ngaythem = '" . date("Y-m-d H:i:s") . "' WHERE KhachHang_id = $id and KichCoSanPham_id = $kcid");
            } else {
                //i
                date_default_timezone_set('Asia/Ho_Chi_Minh');
                $this->db->insertNonParam("insert into giohang values($id, $kcid, $sl,'" . date("Y-m-d H:i:s") . "')");
            }
            sqlsrv_commit($this->db->conn);
            return true;
        } catch (PDOException $e) {
            sqlsrv_rollback($this->db->conn);
            return false;
        }
    }

    public function laySlSpGioHang($khid)
    {
        try {
            return $this->db->selectNonParam("select count(*) as sl from giohang where giohang.KhachHang_id = $khid")[0];
        } catch (PDOException $e) {
            return false;
        }
    }
    public function laySpGioHang($khid, $sort, $limit)
    {
        try {
            $dssp = $this->db->selectNonParam("select sanpham.id as spid, loaisanpham.id as lspid, kichcosanpham.id as kcspid, sanpham.ten, sanpham.gia, loaisanpham.hinhanh, kichcosanpham.kichco, giohang.soluong, sanpham.KhuyenMai_id, khuyenmai.phantram, khuyenmai.thoigian_bd, thoigian_kt
            from giohang
            INNER join kichcosanpham on kichcosanpham.id = giohang.KichCoSanPham_id
            INNER join loaisanpham on loaisanpham.id = kichcosanpham.LoaiSanPham_id and loaisanpham.SanPham_id = kichcosanpham.SanPham_id
            INNER join sanpham on sanpham.id = loaisanpham.SanPham_id and sanpham.id = kichcosanpham.SanPham_id
            left join khuyenmai on khuyenmai.id = sanpham.KhuyenMai_id
            where giohang.KhachHang_id = $khid $sort limit $limit;
            order by ngaythem desc  
            ");

            return array_map(function ($item) {
                if (is_null($item['KhuyenMai_id'])) {
                    return [
                        "spid" => $item['spid'],
                        "lspid" => $item['lspid'],
                        "kcspid" => $item['kcspid'],
                        "ten" => $item['ten'],
                        "gia" => $item['gia'],
                        "hinhanh" => $item['hinhanh'],
                        "kichco" => $item['kichco'],
                        "soluong" => $item['soluong']
                    ];
                } else {
                    if (is_null($item['thoigian_kt'])) {
                        return [
                            "spid" => $item['spid'],
                            "lspid" => $item['lspid'],
                            "kcspid" => $item['kcspid'],
                            "ten" => $item['ten'],
                            "gia" => (float)$item['gia'] - ((float)$item['gia'] * ((float)$item['phantram'] / 100)),
                            "hinhanh" => $item['hinhanh'],
                            "kichco" => $item['kichco'],
                            "soluong" => $item['soluong']
                        ];
                    } else {
                        if (strtotime($item['thoigian_kt']) < strtotime(date('Y-m-d'))) {
                            return [
                                "spid" => $item['spid'],
                                "lspid" => $item['lspid'],
                                "kcspid" => $item['kcspid'],
                                "ten" => $item['ten'],
                                "gia" => $item['gia'],
                                "hinhanh" => $item['hinhanh'],
                                "kichco" => $item['kichco'],
                                "soluong" => $item['soluong']
                            ];
                        } else {
                            return [
                                "spid" => $item['spid'],
                                "lspid" => $item['lspid'],
                                "kcspid" => $item['kcspid'],
                                "ten" => $item['ten'],
                                "gia" => (float)$item['gia'] - ((float)$item['gia'] * ((float)$item['phantram'] / 100)),
                                "hinhanh" => $item['hinhanh'],
                                "kichco" => $item['kichco'],
                                "soluong" => $item['soluong']
                            ];
                        }
                    }
                }
            }, $dssp);
            // return $dssp;
        } catch (PDOException $e) {
            return false;
        }
    }
    public function capNhatSoLuong($id, $loai, $soluong)
    {
        try {
            sqlsrv_begin_transaction($this->db->conn);
            if ($loai == "tang") {
                $sp = $this->db->selectNonParam("select soluong from kichcosanpham where id = $id");
                if (intval($sp[0]['soluong']) < intval($soluong) + 1) {
                    return false;
                }
                $this->db->updateNonParam("UPDATE giohang set giohang.soluong = giohang.soluong + 1 where giohang.KichCoSanPham_id = $id");
            } else {
                $this->db->updateNonParam("UPDATE giohang set giohang.soluong = giohang.soluong - 1 where giohang.KichCoSanPham_id = $id");
            }
            sqlsrv_commit($this->db->conn);
            return true;
        } catch (PDOException $e) {
            sqlsrv_rollback($this->db->conn);
            return false;
        }
    }

    public function xoaSanPham($id)
    {
        try {
            sqlsrv_begin_transaction($this->db->conn);
            $this->db->updateNonParam("delete from giohang where giohang.KichCoSanPham_id = $id");
            sqlsrv_commit($this->db->conn);
            return true;
        } catch (PDOException $e) {
            sqlsrv_rollback($this->db->conn);
            return false;
        }
    }
}


// OFFSET 10 ROWS
// FETCH NEXT 10 ROWS ONLY;
// ORDER BY: required
// OFFSET: optional number of skipped rows
// NEXT: required number of next rows