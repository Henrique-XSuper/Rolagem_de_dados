# 🎲 Jogo de Lançamento de Dados
Este é um projeto simples em C# que simula um jogo de lançamento de três dados. O objetivo é testar a sua sorte e obter uma pontuação total de 15 ou mais.

---
## 🔎 Recursos
- **Lançamento de Dados**: Simula o lançamento de três dados de 6 faces.
- **Cálculo de Pontuação**: A pontuação é a soma dos três dados.
- **Bônus por Sorte**:
Se dois dados tiverem o mesmo valor, o jogador ganha um bônus de +2.
Se todos os três dados tiverem o mesmo valor, o bônus é maior, de +6.
- **Resultado do Jogo**: O programa informa se a pontuação final foi suficiente para ganhar ou se a sorte não esteve a seu favor.
---
## ⚒️Requisitos
vs code/ vs Studio 
.NET SDK instalado.

---
## 🧠 Lógica do Jogo
O jogo funciona da seguinte maneira:<br>
1. Três variáveis (roll1, roll2, roll3) são inicializadas com valores aleatórios entre 1 e 6.<br>
2. A soma dos três valores é calculada e armazenada na variável total.<br>
3. O programa verifica se há dados repetidos para adicionar bônus:<br>
- Se houver um par de números iguais, 2 pontos são adicionados ao total.
- Se os três números forem iguais, 6 pontos são adicionados ao total.
4. Por fim, a pontuação final é comparada a 15:<br>
- Se for igual ou maior que 15, o jogador vence.
- Se for menor que 15, o jogador perde.
