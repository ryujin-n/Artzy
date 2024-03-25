<?php

    
session_start();

if (isset($_SESSION['nomeUsuarioLogin'])) {
    $menu = "header&footer/header_signedon.php";
} else {
    header('Location: sign_in.php');
    $menu = "header&footer/header_signedoff.php";
}