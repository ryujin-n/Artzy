<?php

    
session_start();

if (isset($_SESSION['nomeUsuarioLogin'])) {
    $menu = "header&footer/header_signedon.php";
    $pfp = $_SESSION['fotoPerfilUsuario'];
    $email = $_SESSION['emailUsuarioLogin'];
    $user = $_SESSION['loginUsuarioLogin'];
    $nome = $_SESSION['nomeUsuarioLogin'];
    $area = $_SESSION['areaUsuarioLogin'];
    $banner = $_SESSION['bannerPerfilUsuario'];
    $seguidores = $_SESSION['seguidores'];
    $seguindo = $_SESSION['seguindo'];

} else {
    $menu = "header&footer/header_signedoff.php";
}