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

    <?php include_once("php/cad.php")?>

<form action="" method="post" onsubmit="return false;" name="frmCad" id="frmCad">
        <div class="fundo">
                <div class="lado-esquerdo">
                    <div class="fundo2">
        
                    <div class="log-men">
                        <span class="p-log">
                            já possui uma conta?
                        </span>
                        <button class="btn-log" id="login" onclick="logn()">
                            Entrar
                        </button>
                    </div>
                      
                    </div>
                </div>
                <div class="lado-direito">
                    <div class="cad-fund">
                        <p class="cad_p selecione-none ">Criar uma Conta</p>
                      
                        <div class="row linha1">
                            <div class="col-sm-6 ">
                                <input type="text" name="nome" id="nome" class="nome" placeholder="Insira seu Nome Completo">
                            </div>
                            <div class="col-sm-6">
                                <input type="text" name="email" id="email" class="email" placeholder="Insira seu Email">
                            </div>
                        </div>
                        <div class="col-sm-12 cad-men">
                            <button class="btn-cad selecione-none" id="cad" onclick="cads()" >Cadastrar</button>
                        </div>
                        <div class="col-sm-12 tos" id="tos">
                                <i class="fa-regular fa-square check_b" id="off" onclick="toggleCheck()"></i>
                                 <i class="fa-solid fa-square check_b"id="on"></i>
                                 <i class="fa-solid fa-check check"id="ok"></i>
                                 <span>Li e concordo com os <a href="">Termos de Serviço</a></span>
                        </div>
                        <div class="row linha2">
                            <div class="col-sm-6 " id="sen">
                                <input type="password" name="senha" id="senha" class="senha" placeholder="Insira uma Senha">
                                <i class="fa-solid fa-eye-slash olho" id="olho2"></i>
                                <i class="fa-solid fa-eye olho" id="olho1"></i>
                            </div>

                            <div class="col-sm-6">
                                <button name="area" id="areaa" class="area" onclick="rotateArrow()" onblur="resetArrow()">
                                    <span id="bt_n">Selecione sua Área</span>
                                        <i class="fi fi-br-caret-down" id="seta"></i>
                                            <div class="dp scrollbar" id="ddp"> <!--style="display:none;" -->
                                                <ul class="dp-menu">
                                                    <li class="dp-item">
                                                        <div class="item-content">
                                                            <div class="hov" id="da" onclick="area_sel('da')">Arte Digital</div>
                                                        </div>
                                                    </li>
                                                    
                                                    <li class="dp-item">
                                                        <div class="item-content">
                                                            <div class="hov" id="ta" onclick="area_sel('ta')">Arte Tradicional</div>
                                                        </div>
                                                    </li>
                                                    <li class="dp-item">
                                                        <div class="item-content">
                                                            <div class="hov" id="av"onclick="area_sel('av')">Audiovisual</div>
                                                        </div>
                                                    </li>
                                                
                                                    <li class="dp-item">
                                                            <div class="hov" id="wr" onclick="area_sel('wr')">Escrita</div>
                                                    </li>
                                                </ul>
                                            </div>
                                </button>
                            </div>
                        </div>
                        <input type="text" 
                            style="
                                position: absolute; 
                                top: 40rem;
                                visibility: hidden ;
                                
                            "
                            name="tipo"
                            id="tipo">
                    </div>
                        <input type="text" 
                            style="
                                position: absolute; 
                                top: 47.6rem;
                                left: 50rem;
                                visibility: hidden ;
                                
                            "
                            name="ook"
                            id="ook">
                    </div>
                </div>
            </div>
        </div>
    </form>


        
    <script>

      


        function area_sel(type) {

            const btn = document.getElementById('bt_n');

            console.log(type);


            if (type == "da" ) {
                btn.innerText = "Arte Digital"
                tipo.value = "Arte Digital"
            }
            else if (type == "ta"){
                btn.innerText = "Arte Tradicional"
                tipo.value = "Arte Tradicional"
            }
            else if (type == "av"){
                btn.innerText = "Audiovisual"
                tipo.value = "Audiovisual"
            }
            else if (type == "wr"){
                btn.innerText = "Escrita"
                tipo.value = "Escrita"
            }
        }



    </script>

    <script>

            const nome = document.getElementById('nome');
            const email = document.getElementById('email');
            const senha = document.getElementById('senha');
            const btn = document.getElementById('bt_n');
            const area = document.getElementById('areaa');
            const tipo = document.getElementById('tipo');
            const ook = document.getElementById('ook');
            const form = document.getElementById('frmCad');
            const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        function logn(){
            const destino = "/PHP/Artzy%20-%20Web/sign_in.php"
            form.submit();
            window.location.href = destino;
        }


        function cads() {
          
            if (verify()) {
                alert("Conta criada com Sucesso!");
                ook.value = "ok"
                form.submit();
            }
        }

        function verify() {

            if (nome.value == "") {
                alert("Preencha um nome válido");
                nome.focus();
                return false;
            } else if (email.value == "" || !emailRegex.test(email.value)) {
                alert("Preencha um e-mail válido");
                email.focus();
                return false;
            } else if (senha.value == "") {
                alert("Preencha uma Senha válido");
                senha.focus();
                return false;
            } else if (tipo.value == "") {
                alert("Preencha uma Área válida");
                setTimeout(function() {
                    area.focus();
                }, 0);
                return false;
            } else {
                return true;
            }
        }
    </script>

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
            dropdown.classList.toggle('show'); 
            dropdown.classList.remove('hide');
         }

        function resetDropdown() {
            const dropdown = document.getElementById('ddp');
            const btn = document.getElementById('areaa');

            dropdown.classList.add('hide'); 
            btn.blur()


            setTimeout(function() {
                dropdown.classList.remove('show');
            }, 237);
        }
    </script>

    <script>
        const olho1 = document.getElementById('olho1');
        const olho2 = document.getElementById('olho2');
        const pass = document.getElementById('senha');

        olho1.addEventListener('click', function() {
            pass.type = 'text';
            
            olho1.style.visibility = 'hidden';
            olho2.style.visibility = 'visible';
            pass.focus()
        });

        olho2.addEventListener('click', function() {
            pass.type = 'password';
            
            olho1.style.visibility = 'visible';
            olho2.style.visibility = 'hidden';
            pass.focus()
        });
    </script>

    <script>
        function toggleCheck() {
            const offIcon = document.getElementById('off');
            const onIcon = document.getElementById('on');
            const okIcon = document.getElementById('ok');
            const cad = document.querySelector('.btn-cad');

            if (offIcon.style.display === 'none') {
                offIcon.style.display = 'inline-block';
                onIcon.style.display = 'none';
                okIcon.style.display = 'none';
                cad.classList.remove('btn-cad-on');
                cad.style.pointerEvents = 'none';
            } else {
                offIcon.style.display = 'none';
                onIcon.style.display = 'inline-block';
                okIcon.style.display = 'inline-block';
                cad.classList.add('btn-cad-on'); 
                cad.style.pointerEvents = 'auto';
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