<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/style-cadastro.css">
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>
    <title>Artzy - Cadastro</title>
</head>
<body>
<div class="fundo">
        <div class="lado-esquerdo">
            <div class="fundo2">
                <!-- <img src="src/pijm.png" class="pin" alt="" id="p1">
                <img src="src/pijm.png" class="pin" alt="" id="p2"> -->
            </div>
        </div>
        <div class="lado-direito">
            <div class="cad-fund">
                <p class="cad_p selecione-none ">Criar uma Conta</p>
              
                <div class="row linha1">
                    <div class="col-sm-6 ">
                        <input type="text" name="" id="" class="nome" placeholder="Insira seu Nome Completo">
                    </div>
                    <div class="col-sm-6">
                        <input type="text" name="" id="" class="user" placeholder="Insira seu Usuário">
                    </div>
                </div>
                <div class="col-sm-12 tos" id="tos">
                        <i class="fa-regular fa-square check_b" id="off" onclick="toggleCheck()"></i>
                         <i class="fa-solid fa-square check_b"id="on"></i>
                         <i class="fa-solid fa-check check"id="ok"></i>
                         <span>Li e concordo com os <a href="">Termos de Serviço</a></span>
                </div>
                <div class="row linha2">
                    <div class="col-sm-6 ">
                        <input type="password" name="" id="" class="senha" placeholder="Insira uma Senha">
                        <i class="fa-solid fa-eye-slash olho" id="olho2"></i>
                        <i class="fa-solid fa-eye olho" id="olho1"></i>
                    </div>
                    <div class="col-sm-6">
                        <button name="area" id="area" class="area" onclick="rotateArrow()" onblur="resetArrow()">
                             <span> <?= "Selecione sua Área" ?> </span>
                             <i class="fi fi-br-caret-down" id="seta"></i>
                        </button>
                        <div class="dp scrollbar" id="ddp"> <!--style="display:none;" -->
                            <ul class="dp-menu">
                                <li class="dp-item">
                                    <div class="item-content">
                                        <div class="hov" id="da">Arte Digital</div>
                                    </div>
                                </li>
                                
                                <li class="dp-item">
                                    <div class="item-content">
                                        <div class="hov" id="ta">Arte Tradicional</div>
                                    </div>
                                </li>
                                <li class="dp-item">
                                    <div class="item-content">
                                        <div class="hov" id="av">Audiovisual</div>
                                    </div>
                                </li>
                               
                                <li class="dp-item">
                                        <div class="hov" id="wr">Escrita</div>
                                </li>
                            </ul>
                        </div>

                    </div>
                  
                </div>
            </div>
        </div>
    </div>
</div>

    <script>
    function rotateArrow() {
        const seta = document.getElementById('seta');

        if (seta.classList.contains("arrow-rotated")) {
            seta.classList.add("arrow-initial");
            seta.classList.remove("arrow-rotated");
            resetDropdown(); 
        } else {
            seta.classList.add("arrow-rotated");
            seta.classList.remove("arrow-initial");
            toggleDropdown(); 
        }
    }

    function resetArrow() {
        const seta = document.getElementById('seta');
        seta.classList.remove("arrow-rotated");
        seta.classList.add("arrow-initial");
        resetDropdown(); 
    }

    function toggleDropdown() {
    const dropdown = document.getElementById('ddp');
    dropdown.classList.toggle('show'); // Toggle a classe 'show' para exibir ou ocultar a dropdown
    dropdown.classList.remove('hide'); // Toggle a classe 'show' para exibir ou ocultar a dropdown
}

function resetDropdown() {
    const dropdown = document.getElementById('ddp');
    dropdown.classList.add('hide'); 

    setTimeout(function() {
        dropdown.classList.remove('show');
    }, 290); // Tempo de espera em milissegundos, ajuste conforme necessário
}
</script>

<script>
    const olho1 = document.getElementById('olho1');
    const olho2 = document.getElementById('olho2');
    const pass = document.querySelector('.senha');

    olho1.addEventListener('click', function() {
        pass.type = 'text';
        
        olho1.style.display = 'none';
        olho2.style.display = 'block';
    });

    olho2.addEventListener('click', function() {
        pass.type = 'password';
        
        olho1.style.display = 'block';
        olho2.style.display = 'none';
    });
</script>

<script>
    function toggleCheck() {
        var offIcon = document.getElementById('off');
        var onIcon = document.getElementById('on');
        var okIcon = document.getElementById('ok');

        if (offIcon.style.display === 'none') {
            offIcon.style.display = 'inline-block';
            onIcon.style.display = 'none';
            okIcon.style.display = 'none';
        } else {
            offIcon.style.display = 'none';
            onIcon.style.display = 'inline-block';
            okIcon.style.display = 'inline-block';
        }
    }

    document.getElementById('on').addEventListener('click', function() {
        toggleCheck();
    });

    document.getElementById('ok').addEventListener('click', function() {
        toggleCheck();
    });
</script>



<script src="js/bootstrap.js"></script>
<script src="https://kit.fontawesome.com/aa824ffc0c.js" crossorigin="anonymous"></script>
</body>
</html>