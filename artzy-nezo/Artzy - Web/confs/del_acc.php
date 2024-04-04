<?php
    if ($_POST) {
        include_once('conn.php');

        try {
            $sql = $conn->prepare('DELETE FROM usuario WHERE id_usuario = :id_usuario');

            $sql->execute(array(
                ':id_usuario' => $_POST['perfill']
            ));

            if ($sql->rowCount() > 0) {
                session_unset();
                session_destroy();

                echo '<script>window.location.href = "home.php"</script>';
                exit();
            }
        } catch (PDOException $erro) {
            echo $erro->getMessage();
        }
    }