# BlazorIBGE

Projeto criado para conectar um frontend desevnolvido em Blazor 8 com um backend criado no Desafio do Balta.

O objetivo foi fazer uma conex�o de um front-ent usando o rendermode auto.  

No primeiro acesso, a p�gina � renderizada com o Blazor Server (SSR) e a partir do segundo, no cliente via Blazor WebAssembly (WASM).

### Cities
Essa aba se conecta localmente, atrav�s do arquivo ``Configuration.cs`` com a api desenvolvida no [Desafio do Balta](https://github.com/victorschlindwein/DesafioBalta) e faz o uso dela como back-end.

 <strong>OBS: Para utilizar a API do IBGE linkada como modelo, voc� DEVE habilitar o CORS dentro do ``Program.cs`` disponibilizado no reposit�rio acima. </strong>