<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <?php include_once("php/auth.php")?>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style-menu.css">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel="stylesheet" href="header&footer/style2.css">
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>
    <title>Document</title>
</head>
<body>
    <div class="fundo">
        <div class="pfp">
            <img src="pfp/<?= $id?>/<?= $pfp ?>" alt="">
        </div>

        <div class="txt">
            <span class="Configuraes">
                Configurações
            </span>

            <div class="info-container">
                <span class="nome">
                    <?= $nome ?>
                </span>
                <span class="time">
                    Membro desde <?= $data_formatada_pt ?>
                </span>
            </div>
        </div>

        <div class="menu__">
            <a id="user" href="conf.php?tela=perfil" onclick="select('user')" class="item-m ">
                <i class="fi fi-br-user"></i>
                <span>
                    Perfil
                </span>
            </a>
            
            <a id="rs" href="conf.php?tela=social" onclick="select('rs')" class="item-m">
                <i class="fi fi-br-share"></i>
                <span>
                    Social
                </span>
            </a>

            <div id="hr5" class="hr"></div>

            <a id="acc" href="conf.php?tela=conta" onclick="select('acc')" class="item-m">
                <i class="fi fi-br-admin-alt"></i>   
                <span>
                    Conta
                </span>
            </a>
            <a id="pss" href="conf.php?tela=senha" onclick="select('pss')" class="item-m">
                <i class="fi fi-br-password"></i>
                <span>
                    Senha
                </span>
            </a>
        </div>

       

        
    </div>

    <script>
        function select(option) {
            // Remove a classe 'sel' de todos os itens do menu
            document.querySelectorAll('.item-m').forEach(item => {
                item.classList.remove('sel');
            });

            // Adiciona a classe 'sel' apenas ao item clicado
            document.getElementById(option).classList.add('sel');

            // Armazena o item selecionado no localStorage
            localStorage.setItem('selectedMenuItem', option);
        }

        // Verifica se há um item selecionado no localStorage ao carregar a página
        document.addEventListener("DOMContentLoaded", function() {
            const selectedMenuItem = localStorage.getItem('selectedMenuItem');
            if (selectedMenuItem) {
                // Adiciona a classe 'sel' ao item selecionado armazenado
                document.getElementById(selectedMenuItem).classList.add('sel');
            }
        });
    </script>
    
   


</body>
</html>