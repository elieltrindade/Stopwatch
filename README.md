# ⏱️ Stopwatch - O Cronômetro C#

Bem-vindo ao projeto **Stopwatch** em C#! 🚀 Este é um cronômetro simples e funcional que conta segundos e minutos, ajudando você a manter o tempo sob controle.

## 💻 Funcionalidades

Esse cronômetro permite que você:
- Conte em segundos (10s) ou minutos (1m)
- Acompanhe uma contagem regressiva emocionante com "Ready...", "Set...", "Go..."
- Veja os segundos passarem na tela, até o tempo finalizar com um "Stopwatch finalizado" 👏

## 🛠️ Como Funciona

1. **Menu Principal**: Ao iniciar o programa, o menu é exibido para definir o tempo de contagem.
2. **Configuração de Tempo**: Insira o tempo desejado (por exemplo, `10s` para 10 segundos ou `1m` para 1 minuto).
3. **Início da Contagem**: Após escolher o tempo, você verá uma contagem de preparação, e depois a contagem propriamente dita!
4. **Fim**: O cronômetro avisa quando o tempo acaba. 

## 🧩 Estrutura do Código

- `Menu()`: Exibe o menu, recebe o tempo e o tipo (segundos ou minutos), e passa para o próximo passo.
- `PreStart(int time)`: Uma pequena contagem de "Ready... Set... Go..." pra deixar o clima mais empolgante!
- `Start(int type)`: O coração do cronômetro! Conta segundo a segundo até atingir o tempo configurado.

## 🕹️ Como Usar

1. **Instale o SDK do .NET**: Se ainda não tem o SDK do .NET, baixe e instale a partir do link [aqui](https://dotnet.microsoft.com/download).
2. **Clone ou baixe este código**: Copie e cole o código no seu editor preferido.
3. **Compile e execute o programa**:
   - No terminal, navegue até a pasta do projeto e execute: 
     ```bash
     dotnet run
     ```
4. **Escolha o tempo que deseja contar** e insira no formato:
   - `10s` para 10 segundos
   - `1m` para 1 minuto
5. Aproveite a contagem! 🥳
