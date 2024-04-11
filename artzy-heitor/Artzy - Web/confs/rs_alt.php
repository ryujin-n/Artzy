<?php

if ($_POST) {
    include_once('conn.php');

    try {
        // Recuperar os valores originais dos campos do banco de dados
        $sql = $conn->prepare('SELECT * FROM usuario WHERE id_usuario = :id_usuario');
        $sql->execute(array(':id_usuario' => $_POST['perfill']));
        $row = $sql->fetch(PDO::FETCH_ASSOC);

        // Verificar se houve alterações nos campos e se os novos valores não estão vazios
        $updateFields = array();
        if ($_POST['profi'] !== $row['profissao_usuario'] && !empty($_POST['profi'])) {
            $updateFields['profissao_usuario'] = $_POST['profi'];
        }
      
        if ($_POST['site'] !== $row['site_usuario'] && !empty($_POST['site'])) {
            $updateFields['site_usuario'] = $_POST['site'];
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