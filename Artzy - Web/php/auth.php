<?php

    
session_start();

if (isset($_SESSION['nomeUsuarioLogin'])) {
    $menu = "header&footer/header_signedon.php";
    $pfp = $_SESSION['fotoPerfilUsuario'];
    $user = $_SESSION['loginUsuarioLogin'];
    $nome = $_SESSION['nomeUsuarioLogin'];
} else {
    $menu = "header&footer/header_signedoff.php";
}