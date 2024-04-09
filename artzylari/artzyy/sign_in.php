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
    
    
    <form action="" method="post" onsubmit="return false;" name="frmLog" id="frmLog">
    
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
                    
                    <a class="miss_pass" href="forgor.html">Esqueci minha senha :c</a>
                    
                    <span id="btn">
                        <button id="login" class="login" onclick="loginn()">Entrar</button>
                        <span id="oua">ou</span>
                        <button id="cad" class="cad" formaction="" onclick="cadss()">Cadastrar</button>
                    </span>
                    
                    <?php include_once("php/_logar.php")?>
                    <div class="user-nf" id="nf" style="display:<?=$auth?>;">
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
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const nf = document.getElementById('nf');

    function cadss(){

        const dest = "sign_up.php"
        window.location.href = dest;

    }

    function loginn() {
        if (verify()) {
            const form = document.getElementById('frmLog');
            form.submit();
        }
    }

    function verify() {
        if (nome.value == "") {
            alert("Preencha um nome válida");
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