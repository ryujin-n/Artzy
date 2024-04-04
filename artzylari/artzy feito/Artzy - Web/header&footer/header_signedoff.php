<!DOCTYPE html>
<html lang="br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>header</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style.css">
    <link rel='stylesheet'
        href='https://cdn-uicons.flaticon.com/2.2.0/uicons-solid-rounded/css/uicons-solid-rounded.css'>
    <link rel='stylesheet'
        href='https://cdn-uicons.flaticon.com/2.2.0/uicons-regular-rounded/css/uicons-regular-rounded.css'>
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>

</head>

<body>
    <nav class="fixed-top " style="margin-top:-1rem; padding:0 0.2rem 0  0.2rem;">
        <div class="menu">
            <ul> <!-- mobile -->

            </ul>

            <nav class="menu_">
                <li id="logo" class="menu-logo">
                <a href="home.php">

                    <img src="src/logo.png" class="logo" onerror="this.onerror=null; this.src='../src/logo.png';">
                </a>
                        
                </li>
                <li id="exp" class="menu-nav">
                    <button class="menu-nav dropdown">
                        <p class="Explorar">
                            Explorar
                        </p>
                    </button>
                </li>
               
                <li id="jb" class="menu-nav">
                    <button class="menu-nav">
                        <span class="Servios">
                            Serviços
                        </span>
                    </button>
                    <div class="dp3" id="jbs"> <!--style="display:none;" -->
                        <ul class="dp-menu">
                            <li style="margin-top: 12px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fi fi-br-shop"></i>
                                    <span>Encontrar um Artista</span>
                                </div>
                            </li>
                            <li style="margin-top: 12px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fi fi-br-apartment"></i>
                                    <span>Encontrar um Estúdio</span>
                                </div>
                            </li>
                        </ul>
                    </div>
                </li>

                <li id="srch" class="menu-search">
                    <i class="fas fa-search search-icon"></i>
                    <input type="text" role="search" class="search-bar" placeholder="Pesquisar">
                </li>

                <li id="loj">
                    <i class="fi fi-sr-shopping-cart icons shop"></i>
                </li>

                <li id="logbt">
                    <a href="sign_in.php">
                        <div class="login">
                            <i class="fi fi-br-pencil-paintbrush  icon-login"></i>
                            <span class="login-btn">Entrar</span>
                        </div>
                    </a>
                </li>
                <li id="cadbt">
                    <a href="sign_up.php">
                        <div class="cad">
                            <i class="fi fi-br-address-card icon-cad"></i>
                            <span class="cad-btn">Criar Conta</span>
                        </div>
                    </a>
                </li>

                <li id="borger">
                    <button id="menu-b" onclick="toggleMenu()"><i class="fi fi-br-menu-burger m-icon" id="men"></i></button>
                    <div class="dp" id="exps"> <!--style="display:none;" -->
                        <ul class="dp-menu">
                            <li style="margin-top: 12px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fi fi-br-apartment"></i>
                                    <span>Sobre Artzy</span>
                                </div>
                            </li>
                            <li>
                                <div id="hr1" class="hr"></div>
                            </li>
                            <li style="margin-top: 12px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fa-brands fa-x-twitter"></i>
                                    <span>Twitter</span>
                                </div>
                            </li>
                            <li style="margin-top: 10px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fa-brands fa-instagram"></i>
                                    <span style="margin-left: 6px;">Instagram</span>
                                </div>
                            </li>
                            <li>
                                <div id="hr2" class="hr"></div>
                            </li>
                            <li style="margin-top: 12px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fi fi-br-auction"></i>
                                    <span>ToS</span>
                                </div>
                            </li>
                            <li style="margin-top: 12px;" class="dp-item">
                                <div class="item-content">
                                    <i class="fi fi-sr-lock"></i>
                                    <span>Privacidade</span>
                                </div>
                            </li>
                        </ul>
                    </div>
                </li>
            </nav>
            <br>



        </div>
    </nav>

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            function controlDropdown(dropdownButton, dropdownMenu) {
                dropdownButton.addEventListener("mouseenter", function () {
                    dropdownMenu.style.display = "inline-block";
                });

                dropdownButton.addEventListener("mouseleave", function () {
                    setTimeout(function () {
                        if (!dropdownButton.matches(":hover") && !dropdownMenu.matches(":hover")) {
                            dropdownMenu.style.display = "none";
                        }
                    }, 200);
                });

                dropdownMenu.addEventListener("mouseleave", function () {
                    dropdownMenu.style.display = "none";
                });
            }

            const dropdownButtons = document.querySelectorAll(".menu-nav");
            dropdownButtons.forEach(function (dropdownButton) {
                const dropdownMenu = dropdownButton.nextElementSibling;
                if (dropdownMenu && (dropdownMenu.classList.contains("dp") || dropdownMenu.classList.contains("dp2") || dropdownMenu.classList.contains("dp3"))) {
                    controlDropdown(dropdownButton, dropdownMenu);
                }
            });
        });
    </script>

    <script>

        function toggleMenu() {
            const dropdown = document.querySelector('.dp');
            if (dropdown.style.display === 'none' || dropdown.style.display === '') {
                dropdown.style.display = 'inline-block';
                document.getElementById("menu-b").addEventListener("focusout", function (event) {
                    if (!dropdown.contains(event.relatedTarget)) {
                        dropdown.style.display = 'none';
                    }
                });
            } else {
                dropdown.style.display = 'none';
            }
        }
    </script>
    
    <script src="https://kit.fontawesome.com/aa824ffc0c.js" crossorigin="anonymous"></script>

</body>

</html>