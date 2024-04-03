<?php

$envio="";

if ($_POST) {

    include_once("conn.php");

    $imagem_temp = $_FILES['imagem']['tmp_name'];
    $thumb_temp = $_FILES['thumbnail']['tmp_name'];
    
    try {
        $sql = $conn->prepare('
            INSERT INTO arte
            (id_usuario_arte, nome_arte, img_arte, descr_arte, thumb_arte)
            VALUES
            (:id_usuario_arte, :nome_arte, :img_arte, :descr_arte, :thumb_arte)
        ');
    
        $sql->execute(array(
            ':id_usuario_arte' => $id,
            ':nome_arte' => $_POST['titulo-arte'],
            ':img_arte' => $_FILES['imagem']['name'],
            ':thumb_arte' => $_FILES['thumbnail']['name'],
            ':descr_arte' => $_POST['desc'],
        ));
    
        if ($sql->rowCount() > 0) {
            $pasta = 'galeria/'.$id.'/';
    
            if (!file_exists($pasta)) {
                mkdir($pasta, 0777, true); // Cria a pasta recursivamente com permissões completas
            }
    
            $foto = $pasta . $_FILES['imagem']['name'];
            $thumb = $pasta . $_FILES['thumbnail']['name'];
    
            // Move os arquivos temporários para a pasta de destino
            move_uploaded_file($imagem_temp, $foto);
            move_uploaded_file($thumb_temp, $thumb);
            $envio="true";
        }
    } catch (PDOException $e) {
        echo "Erro ao inserir arte: " . $e->getMessage();
    }

}