<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="rs.css">
</head>
<body>

<?php include_once("rs_alt.php")?>

    <form action="" method="post" onsubmit="return false;" id="socials" name="socials">
        <div class="rs-fundo">
            <span class="redes-sociais">
                Sociais
            </span>

            <span class="sub-tit">
                Links de contato e mídias sociais disponíveis publicamente
            </span>
        </div>

        <div class="rs">
        
            <div class="user">
                <span class="Usurio">
                    Profissão
                </span>
                <input type="text" name="profi" id="profi" class="user-in">
            </div>
            
            <div class="bio">
                <span class="bio-s">
                    Site
                </span>
                <input type="text" name="site" id="sitee" class="bio-in" >
            </div>

            <button class="enviarr" onclick="enviar('prof')">
                <i class="fi fi-br-plus e-ii"></i>
                <span >
                    Add
                </span>
            </button>

            <button class="enviarr" id="e2" onclick="enviar('site')">
                <i class="fi fi-br-plus e-ii"></i>
                <span >
                    Add
                </span>
            </button>
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
        const form = document.getElementById("socials")
        const prof = document.getElementById("profi")
        const site = document.getElementById("sitee")


        function enviar() {
            if (verify()) {
                form.submit();
            }
        }

        function verify() {
            var profValue = prof.value.trim();
            var siteValue = site.value.trim();

            var profOriginal = '<?=  $profi; ?>'; 
            var siteOriginal = '<?= $site; ?>'; 

            var changes = {};

            // Verificar se houve alterações e se os novos valores não estão vazios
            if (profValue !== profOriginal && profValue !== "") {
                changes.prof = profValue;
            }
            if (siteValue !== siteOriginal && siteValue !== "") {
                changes.site = siteValue;
            }

            // Se não houver alterações válidas, exiba um alerta
            if (Object.keys(changes).length === 0) {
                alert("Nenhuma alteração válida foi feita.");
                return false;
            }

            // Se houver alterações, exiba um alerta com as alterações a serem enviadas
            console.log("Alterações a serem enviadas: " + JSON.stringify(changes));

            return true;
        }
    </script>


</body>
</html>