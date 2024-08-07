<?php
include_once(__DIR__ . "/../includes/config.php");
?>
<?php
class Database
{
    public $serverName   = DB_SERVERNAME;
    public $port   = DB_PORT;
    public $user   = DB_USER;
    public $pass   = DB_PASS;
    public $dbname = DB_NAME;

    public $conn;
    public $error;

    public function __construct()
    {
        $this->connectDB();
    }
    private function connectDB()
    {
        try {
            $connectionInfo = array(
                "Database" => $this->dbname,
                "UID" => $this->user,
                "PWD" => $this->pass,
                "TrustServerCertificate" => true,
                "CharacterSet" => "UTF-8",
            );
            $this->conn = sqlsrv_connect($this->serverName, $connectionInfo);
        } catch (PDOException $e) {
            $this->error = "Connection fail" . $e->getMessage();
            return false;
        }
    }

    // // $sql = "INSERT INTO Table_1 (id, data) VALUES (?, ?)";
    // // $params = array(1, "some data");
    public function selectNonParam($query)
    {
        try {
            $statement = sqlsrv_query($this->conn, $query);
            $data = [];
            while ($row = sqlsrv_fetch_array($statement, SQLSRV_FETCH_ASSOC)) {
                array_push($data, $row);
            }
            return $data;
        } catch (PDOException $e) {
            throw new PDOException("error");
        }
    }

    public function insertNonParam($query)
    {
        try {
            $statement = sqlsrv_query($this->conn, ($query . " Select SCOPE_IDENTITY()"));
            $x = sqlsrv_next_result($statement);
            $y = sqlsrv_fetch($statement);
            $id = sqlsrv_get_field($statement, 0);
            return $id;
        } catch (PDOException $e) {
            throw new PDOException("error");
        }
    }

    public function updateNonParam($query)
    {

        try {
            $statement = sqlsrv_query($this->conn, $query);
            return true;
        } catch (Exception $err) {
            throw new PDOException("error");
        }
    }

    public function deleteNonParam($query)
    {
        try {
            $statement = sqlsrv_query($this->conn, $query);
            return true;
        } catch (Exception $err) {
            throw new PDOException("error");
        }
    }
}
