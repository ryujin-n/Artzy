<?php
session_start();

// Verifica as credenciais do usuário
if ($login_ok) {
    // Defina a variável de sessão com o caminho da foto de perfil do usuário
    $_SESSION['pfp'] = $fotopadrao;

    // Redirecione o usuário para a página principal ou para onde quer que você queira enviá-lo após o login
    header('Location: home.html');
    exit();
} else {
    // Se as credenciais estiverem incorretas, exiba uma mensagem de erro
    $erro_login = true;
}
?>
