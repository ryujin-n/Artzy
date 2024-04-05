<?php
// Configurações de conexão com o banco de dados
$servername = "127.0.0.1";
$username = "root";
$password = "";
$database = "artzy";

// Cria a conexão com o banco de dados
$conn = new mysqli($servername, $username, $password, $database);

// Verifica a conexão
if ($conn->connect_error) {
    die("Erro de conexão: " . $conn->connect_error);
}

// Consulta SQL para buscar nomes de usuários e suas fotos na tabela 'usuario'
$sql = "SELECT nome_usuario, fotoP_usuario FROM usuario";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // Array associativo para armazenar os nomes de usuários e suas fotos
    $users = array();

    // Itera sobre os resultados da consulta e adiciona os nomes de usuário e suas fotos ao array
    while($row = $result->fetch_assoc()) {
        $user = array(
            "nome_usuario" => $row['nome_usuario'],
            "fotoP_usuario" => $row['fotoP_usuario']
        );
        $users[] = $user;
    }

    // Retorna os dados dos usuários como um array JSON
    $users_json = json_encode($users);
} else {
    $users_json = json_encode(array()); // Retorna um array vazio se não houver resultados
}

// Fecha a conexão com o banco de dados
$conn->close();
?>

<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>header</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="header&footer/style2.css">
    <link rel='stylesheet'
        href='https://cdn-uicons.flaticon.com/2.2.0/uicons-solid-rounded/css/uicons-solid-rounded.css'>
    <link rel='stylesheet'
        href='https://cdn-uicons.flaticon.com/2.2.0/uicons-regular-rounded/css/uicons-regular-rounded.css'>
    <link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.2.0/uicons-bold-rounded/css/uicons-bold-rounded.css'>
</head>

<body>
    <nav class="logged">
        <div class="menu">
            <ul> <!-- mobile -->

            </ul>

            <nav class="menu_">
                <li id="logo" class="menu-logo">
                        <img src="src/logo.png" class="logo" onerror="this.onerror=null; this.src='../src/logo.png';">
                        
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
                    <div class="dp3" id="jbs">
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
                        <input type="text" id="searchInput" class="search-bar" placeholder="Pesquisar">
                        <div id="searchResults" class="autocomplete-results"></div>
                    </li>

                <li id="env">
                    <i class="fa-solid fa-arrow-up-from-bracket icons env"></i>
                </li>
                <li id="notf">
                    <i class="fi fi-br-bell icons notf"></i>
                    <i class="fi fi-sr-bell icons notf off"></i>

                </li>
                <li id="msg">
                <i class="fi fi-sr-paper-plane-top icons msg"></i>
                </li>
                <li id="loj">
                    <i class="fi fi-sr-shopping-cart icons shop"></i>
                </li>

                <li id="pfp">
                    
                    <a href="profile.php">
                        <div class="pfp">
                            <img src="pfp/<?=$pfp?>" alt="">
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
                            <li style="margin-top: 12px;" class="dp-item">
                               <a href="logout.php">
                                    <div class="item-content">
                                        <i class="fi fi-br-leave"></i>
                                        <span>Sair</span>
                                    </div>
                               </a> 
                            </li>
                        </ul>
                    </div>
                </li>
            </nav>
            <br>
        </div>
    </nav>
<div>
    <li id="pfp">   
    <a href="profile.php">
        <div class="pfp">
            <img src="<?php echo $pfp; ?>" alt="Foto de Perfil">
        </div>
    </a>
</li>
</div>

<script>

    document.addEventListener("DOMContentLoaded", function () {
        const searchInput = document.getElementById("searchInput");
        const searchResults = document.getElementById("searchResults");

        const users = <?php echo $users_json; ?>;

        searchInput.addEventListener("input", function () {
            const searchTerm = searchInput.value.trim().toLowerCase();
            if (searchTerm === '') {
                searchResults.style.display = 'none';
                return;
            }

            searchResults.innerHTML = "";

            const filteredUsers = users.filter(function (user) {
                return user.nome_usuario.toLowerCase().includes(searchTerm);
            });

            if (filteredUsers.length > 0) {
                filteredUsers.forEach(function (user) {
                    const li = document.createElement("li");
                    const img = document.createElement("img");
                    img.src = user.fotoP_usuario !== '' ? user.fotoP_usuario : '<?php echo $pfp; ?>';
                    img.alt = "Foto de perfil de " + user.nome_usuario;
                    li.appendChild(img);
                    li.appendChild(document.createTextNode(user.nome_usuario));
                    li.addEventListener("click", function () {                        
                        window.location.href = `profile.php?name=${encodeURIComponent(user.nome_usuario)}`;
                    });
                    searchResults.appendChild(li);
                });

                searchResults.style.display = 'block';
            } else {
                searchResults.style.display = 'none';
            }
        });
        document.addEventListener("click", function (event) {
            if (!searchResults.contains(event.target)) {
                searchResults.style.display = 'none';
            }
        });
    });

</script>


    <script>

        document.addEventListener("DOMContentLoaded", function () {
            const searchInput = document.getElementById("searchInput");
            const searchResults = document.getElementById("searchResults");

            const users = <?php echo $users_json; ?>;

            searchInput.addEventListener("input", function () {
                const searchTerm = searchInput.value.trim().toLowerCase();
                if (searchTerm === '') {
                    searchResults.style.display = 'none';
                    return;
                }

                // Limpa os resultados anteriores
                searchResults.innerHTML = "";

                // Filtra os usuários cujos nomes correspondem ao termo de pesquisa
                const filteredUsers = users.filter(function (user) {
                    return user.nome_usuario.toLowerCase().includes(searchTerm);
                });

                if (filteredUsers.length > 0) {
                    // Adiciona resultados à lista de resultados
                    filteredUsers.forEach(function (user) {
                        const li = document.createElement("li");
                        const img = document.createElement("img");
                        img.src = user.fotoP_usuario !== '' ? user.fotoP_usuario : 'pfp/fotopadrao.png';
                        img.alt = "Foto de perfil de " + user.nome_usuario;
                        li.appendChild(img);
                        li.appendChild(document.createTextNode(user.nome_usuario));
                        li.addEventListener("click", function () {                        
                            // Redireciona o usuário para a página "profile.php" com o nome do usuário como parâmetro de consulta
                            window.location.href = `profile.php?name=${encodeURIComponent(user.nome_usuario)}`;
                        });
                        searchResults.appendChild(li);
                    });

                    // Exibe a lista de resultados
                    searchResults.style.display = 'block';
                } else {
                    // Se não houver resultados, oculta a lista de resultados
                    searchResults.style.display = 'none';
                }
            });

            // Fechar a lista de resultados ao clicar em qualquer lugar fora dela
            document.addEventListener("click", function (event) {
                if (!searchResults.contains(event.target)) {
                    searchResults.style.display = 'none';
                }
            });
        });

    </script>

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