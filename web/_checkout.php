<?php
// Array
// (
//     [addressId] => 3
//     [userId] => 37
//     [sp] => Array
//         (
//             [0] => 23_3
//         )

//     [bankCode] => vnpay
//     [language] => vn
// )
if (strtoupper($_SERVER['REQUEST_METHOD']) === 'POST') {
    if ($_POST['bankCode'] == "cod") {
        require __DIR__ . '/_thanhtoan.php';
    } else {
        require __DIR__ . '/vnpay/vnpay_create_payment.php';
    }
}
