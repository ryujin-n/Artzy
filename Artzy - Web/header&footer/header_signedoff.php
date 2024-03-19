<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>header</title>
    <link rel="stylesheet" href="style.css">
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-solid-rounded/css/uicons-solid-rounded.css'>
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-regular-rounded/css/uicons-regular-rounded.css'>
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>

</head>
<body>
    <nav class="not-logged">
        <div class="menu">
            <ul> <!-- mobile --> 

            </ul>

            <nav class="menu_">
                <li class="menu-logo">
                    <a href="http://localhost/T14_PHP/Artzy%20-%20Web/header&footer/header.php">
                        <img src="../src/logo.png" class="logo" >
                    </a>
                </li>
                <li class="menu-nav">
                    <button class="menu-nav dropdown" style="height: 50px;">
                        <span class="Explorar">
                            Explorar
                        </span>
                    </button>
                    
                   
                </li>
                <li class="menu-nav">
                    <button class="menu-nav"style="height: 50px;">
                    <span class="Loja">
                        Loja
                    </span>
                    </button>
                </li>
                <li class="menu-nav">
                    <button class="menu-nav"style="height: 50px;">
                    <span class="Servios">
                        Serviços
                    </span>
                    </button>
                </li>

                <li class="menu-search">
                    <i class="fas fa-search search-icon"></i>
                    <input type="search" class="search-bar" placeholder ="Pesquisar">
                </li>

                <li>
                    <i class="fi fi-sr-shopping-cart icons shop"></i>
                </li>

                <li>
                    <div class="login">
                        <i class="fi fi-br-pencil-paintbrush  icon-login"></i>
                        <span class="login-btn">Entrar</span>
                    </div>
                </li>
                <li>
                    <div class="cad">
                        <i class="fi fi-br-address-card icon-cad"></i>
                        <span class="cad-btn">Criar Conta</span>
                    </div>
                </li>

                <li>
                    <i class="fi fi-br-menu-burger m-icon"></i>
                </li>
            </nav>
            <br>
                     <div class="dp" id="exp"> <!--style="display:none;" -->
                        <ul class="dropdown-menu">
                            <li><a class="dropdown-item" href="#"><i class="fi fi-br-apartment"></i><span>Sobre Artzy</span></a></li>
                            <li><hr class="dropdown-divider"></li>
                            <li><a class="dropdown-item" href="#"><i class="fa-brands fa-x-twitter"></i><span>Twitter</span></a></li>
                            <li><a class="dropdown-item" href="#"><i class="fa-brands fa-instagram"></i><span>Instagram</span></a></li>
                            <li><hr class="dropdown-divider"></li>
                            <li><a class="dropdown-item" href="#"><i class="fi fi-br-auction"></i><span>Termos de Serviço</span></a></li>
                            <li><a class="dropdown-item" href="#"><i class="fa-solid fa-lock"></i><span></span></a></li>
                        </ul>
                    </div>
            
        </div>
    </nav>

    <script src="https://kit.fontawesome.com/aa824ffc0c.js" crossorigin="anonymous"></script>
</body>
</html>