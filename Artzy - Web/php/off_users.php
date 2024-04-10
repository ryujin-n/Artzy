<?php

include_once("conn.php");

try {
    $sql = $conn->query("SELECT * FROM usuario");
    
    if($sql->rowCount() >0)
    {
        foreach($sql as $linha)
        {
            $id_off = $linha['id_usuario'];
            $nome_off = $linha['nome_usuario'];
            $user_off = $linha['login_usuario'];
            $pfp_off = $linha['fotoP_usuario'];
            $banner_off = $linha['banner_usuario'];
            $bio_off = $linha['bio_usuario'];
            $email_off = $linha['email_usuario'];
            $area_off = $linha['area_usuario'];
            $data_off = $linha['data_usuario']; 
            $data_formatada_off = new DateTime($data_off);
            $data_formatada_pt_off = $data_formatada_off->format("F \\d\\e Y");

            $profi_off = $linha['profissao_usuario'];
            $site_off = $linha['site_usuario'];
        }
    }
} catch(PDOException $erro) {
    echo $erro->getMessage();
}