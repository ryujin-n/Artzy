<?php

if ($_POST) {
    include_once('conn.php');

    if (isset($_FILES['banner_alt'])) {
        $ban = $_FILES['banner_alt'];
    }
    
    if (isset($_FILES['avatar_alt'])) {
        $av = $_FILES['avatar_alt'];
    }
    try {
        // Recuperar os valores originais dos campos do banco de dados
        $sql = $conn->prepare('SELECT * FROM usuario WHERE id_usuario = :id_usuario');
        $sql->execute(array(':id_usuario' => $_POST['perfill']));
        $row = $sql->fetch(PDO::FETCH_ASSOC);

        // Verificar se houve alterações nos campos e se os novos valores não estão vazios
        $updateFields = array();
        if ($_POST['usuario'] !== $row['login_usuario'] && !empty($_POST['usuario'])) {
            $updateFields['login_usuario'] = $_POST['usuario'];
        }
        if ($av !== null && $_FILES['avatar_alt']['name'] !== $row['fotoP_usuario'] && !empty($_FILES['avatar_alt']['name'])) {
            $updateFields['fotoP_usuario'] = $_FILES['avatar_alt']['name'];
        }
        if ($ban !== null && $_FILES['banner_alt']['name'] !== $row['banner_usuario'] && !empty($_FILES['banner_alt']['name'])) {
            $updateFields['banner_usuario'] = $_FILES['banner_alt']['name'];
        }
        if ($_POST['bio'] !== $row['bio_usuario'] && !empty($_POST['bio'])) {
            $updateFields['bio_usuario'] = $_POST['bio'];
        }
        if ($_POST['tipo'] !== $row['area_usuario'] && !empty($_POST['tipo'])) {
            $updateFields['area_usuario'] = $_POST['tipo'];
        }

        // Se houver campos para atualizar, execute a atualização
        if (!empty($updateFields)) {
            $sql = $conn->prepare('
                UPDATE usuario SET
                    ' . implode(', ', array_map(function($key) { return "$key = :$key"; }, array_keys($updateFields))) . '
                WHERE id_usuario=:id_usuario
            ');
            $updateData = array_merge($updateFields, array(':id_usuario' => $_POST['perfill']));
            $sql->execute($updateData);

            if ($sql->rowCount() > 0) {
                $pasta = 'pfp/' . $_POST['perfill'] . '/';
                if (!file_exists($pasta)) {
                    mkdir($pasta, 0777, true);
                }

                $pasta2 = 'pfp/banner/' . $_POST['perfill'] . '/';
                if (!file_exists($pasta2)) {
                    mkdir($pasta2, 0777, true);
                }

                // Mover os arquivos de avatar e banner para as pastas correspondentes, se forem enviados
                if ($av !== null && $av['error'] === UPLOAD_ERR_OK) {
                    $foto = $pasta . $av['name'];
                    move_uploaded_file($av['tmp_name'], $foto);
                }
                
                if ($ban !== null && $ban['error'] === UPLOAD_ERR_OK) {
                    $ban_f = $pasta2 . $ban['name'];
                    move_uploaded_file($ban['tmp_name'], $ban_f);
                }

                echo '<script>alert("Atualização realizada com sucesso!")</script>';
            } else {
                echo '<script>alert("Erro ao atualizar!")</script>';
            }
        } else {
            echo '<script>alert("Nada para atualizar!")</script>';
        }
    } catch (PDOException $erro) {
        echo $erro->getMessage();
    }
}