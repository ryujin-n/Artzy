<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="pss.css">
</head>
<body>

    <?php include_once('pss_alterar.php')?>

    <form action="" method="post" onsubmit="return false;" id="password" name="password">
        <div class="senha-titulo">
            <span class="senha">
                senha
            </span>

            <span class="Alterar-a-senha">
                Alterar a senha
            </span>
        </div>

        <div class="senha-fund">
            <span class="Nova-senha">
                Nova senha
            </span>

            <input type="text" class="senha1" name="senha1" id="senha1"oninput="compararSenhas()">

            <span class="Nova-senha2">
                Confirmar senha
            </span>

            <input type="text" class="senha2" name="senha2" id="senha2" oninput="compararSenhas()">

            <button class="enviar4" onclick="enviar()">
                <i class="fi fi-br-file-upload e-i4"></i>
                <span class="Alterar-Imagem">
                    Salvar
                </span>
            </button>

            <div class="aviso" id="aviso"  style="display:none;">
                <span class="aviso-text">Senhas não coincidem</span>
            </div>
        </div>

        <input type="text" 
        style="
            position: absolute; 
            top: 5.2rem;
            left: 9rem;
            display:none;
            
        "
        name="perfill"
        id="perfill"
        value="<?=$id?>">
    </form>

    <script>
        let senha1 = document.getElementById('senha1');
        let senha2 = document.getElementById('senha2');
        let aviso = document.getElementById("aviso")
        const form = document.getElementById("password")

        function enviar() {
            if (aviso.style.display === 'none') {
                if (senha1.value !== "" && senha2.value !== "" && senha1.value === senha2.value) {
                    form.submit();
                } else {
                    alert("Por favor, corrija os erros antes de enviar o formulário.");
                }
            } else {
                alert("Por favor, corrija os erros antes de enviar o formulário.");
            }
        }

        function compararSenhas() {
            if (senha1.value === senha2.value || senha1.value == "" && senha2.value == "") {
                aviso.style.display = 'none'
            } else {
                aviso.style.display = 'block'
            }
        }
    </script>
</body>
</html>