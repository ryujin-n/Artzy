<?php
if ($_POST) {
    print_r($_POST);

    if ($_POST['ook'] == 'ok') {

        include_once('conn.php');

        try {
            $sql = $conn->prepare('
                insert into usuario
                    (nome_usuario, login_usuario, senha_usuario, email_usuario, area_usuario)
                    values(:nome_usuario, :login_usuario, :senha_usuario, :email_usuario, :area_usuario)
            ');

            $sql->execute(array(
                ':nome_usuario' => $_POST['nome'],
                ':login_usuario' => $_POST['user'],
                ':senha_usuario' => $_POST['senha'],
                ':email_usuario' => $_POST['email'],
                ':area_usuario' => $_POST['tipo'],
            ));

            if ($sql->rowCount() > 0) {
                $userId = $conn->lastInsertId();
                $pasta = 'pfp/' .$conn->lastInsertId() . '/';
                if (!file_exists($pasta)) {
                    mkdir($pasta, 0777, true);
                    copy('pfp/fotopadrao.png', $pasta . 'fotopadrao.png');
                }

                $pasta2 = 'pfp/banner/' .$conn->lastInsertId() . '/';
                if (!file_exists($pasta2)) {
                    mkdir($pasta2, 0777, true);
                    copy('pfp/bannerpadrao.png', $pasta2 . 'bannerpadrao.png');
                }

                header("Location: sign_in.php");
            }
        } catch (PDOException $erro) {
            echo $erro->getMessage();
        }
    }
}