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

// Consulta SQL para buscar nomes de usuários na tabela 'usuario'
$sql = "SELECT nome_usuario FROM usuario";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // Array para armazenar os nomes de usuários
    $names = array();

    // Itera sobre os resultados da consulta e adiciona os nomes ao array
    while($row = $result->fetch_assoc()) {
        $names[] = $row['nome_usuario'];
    }

    // Retorna os nomes como um array JSON
    echo json_encode($names);
} else {
    echo json_encode(array()); // Retorna um array vazio se não houver resultados
}

// Fecha a conexão com o banco de dados
$conn->close();
?>
