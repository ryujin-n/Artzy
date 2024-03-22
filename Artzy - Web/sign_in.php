<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/style-login.css">
    <title>Artzy - Login</title>
</head>
<body>
    
    <?php include_once("php/_logar.php")?>

    <form action="php/_logar.php" method="post" name="frmCad" id="frmCad">
        <div class="fundo">
            <div class="lado-esquerdo">
                <div class="fundo2">
                    <img src="src/pijm.png" class="pin" alt="" id="p1">
                    <img src="src/pijm.png" class="pin" alt="" id="p2">
                </div>
            </div>
            <div class="lado-direito">
                <div class="log-fund">
                    <p class="login_p selecione-none ">Login</p>

                    <input type="text" name="nome" id="nome" class="Email" placeholder="Insira seu Usuário">

                    <input type="password" name="senha" id="senha"class="Senha" placeholder="Insira sua Senha">

                    <a class="miss_pass" href="">Esqueci minha senha :c</a>
                
                    <span id="btn">
                        <button id="login" class="login" onclick="verify()">Entrar</button>
                        <span id="oua">ou</span>
                        <button id="cad" class="cad" onclick="cadss()">Cadastrar</button>
                    </span>
                    
                    <div class="user-nf" style="">
                        <span class="nf-text">Nome ou Senha incorretos</span>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>

<script>

    const nome = document.getElementById('nome');
    const senha = document.getElementById('senha');
    const form = document.getElementById('frmCad');
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    function cadss(){

        const destino = "/PHP/Artzy%20-%20Web/sign_up.php"
        window.location.href = destino;

    }

    // function loginn(){
    //     if (verify()) {
            // const destino = "/PHP/Artzy%20-%20Web/php/_logar.php"
    //         form.submit();
    //         window.location.href = destino;
    //     }
       
    // }

    function verify() {
        if (nome.value == "") {
            alert("Preencha um nome válido");
            nome.focus();
            return false;
       
        } else if (senha.value == "") {
            alert("Preencha uma Senha válida");
            senha.focus();
            return false;

        } else {
            return true;
        }
    }
</script>
</html>