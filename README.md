# BlazorIBGE

Projeto criado para conectar um frontend desevnolvido em Blazor 8 com um backend criado no Desafio do Balta.

O objetivo foi fazer a criação de um front-ent usando o @rendermode InteractiveAuto.  

No primeiro acesso, a página é renderizada com o Blazor Server (SSR) e a partir do segundo, no cliente via Blazor WebAssembly (WASM).

### Cities
Essa aba se conecta localmente com a api desenvolvida no [Desafio do Balta](https://github.com/victorschlindwein/DesafioBalta) e faz o uso dela como back-end.

A API foi inserida dentro da solução desse projeto e está configurada no ``appsettings.json`` para iniciar em uma porta fixa.

Caso seja realizada a troca dessa porta, lembre-se de atualizar o arquivo ``Configuration.cs`` no projeto BlazorIBGE.Client.