<?php

function getConversation($user_id, $conn)
{
    // Consulta SQL para selecionar todas as conversas do usuário
    $sql = "SELECT *
            FROM conversations
            WHERE user_1 = ? OR user_2 = ?
            ORDER BY conversation_id DESC";

    // Prepara e executa a consulta
    $stmt = $conn->prepare($sql);
    $stmt->execute([$user_id, $user_id]);

    // Verifica se há resultados
    if ($stmt->rowCount() > 0) {
        // Recupera todas as conversas
        $conversations = $stmt->fetchAll();
        $user_data = [];

        // Itera sobre cada conversa
        foreach ($conversations as $conversation) {
            // Determina o ID do outro usuário na conversa
            $other_user_id = ($conversation['user_1'] == $user_id) ? $conversation['user_2'] : $conversation['user_1'];

            // Consulta SQL para recuperar os dados do outro usuário
            $sql2 = "SELECT *
                     FROM users
                     WHERE user_id = ?";
            $stmt2 = $conn->prepare($sql2);
            $stmt2->execute([$other_user_id]);

            // Recupera os dados do outro usuário e os adiciona ao array de conversas
            $other_user_data = $stmt2->fetch();
            if ($other_user_data) {
                $user_data[] = $other_user_data;
            }
        }

        return $user_data;
    } else {
        // Se não houver conversas, retorna um array vazio
        return [];
    }
}
?>
