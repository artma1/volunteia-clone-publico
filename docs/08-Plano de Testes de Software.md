# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 


| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-01 - A aplicação deve permitir que o usuário se cadastre. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
| **Critério de Êxito** 	| O cadastro foi realizado com sucesso. |

---

| **Caso de Teste** 	| **CT-02 – Realizar login** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-02 - A aplicação deve permitir que o usuário realize login. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue efetuar o login. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Inserir e-mail e senha cadastrados <br> - Clicar em "Login" |
| **Critério de Êxito** 	| O usuário conseguiu acessar sua conta com sucesso. |

---

| **Caso de Teste** 	| **CT-03 – Criar diferentes tipos de usuários** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-03 - A aplicação deve permitir criar diferentes tipos de usuários (instituição, pessoal). |
| **Objetivo do Teste** 	| Verificar se o sistema permite criar diferentes tipos de usuários. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Criar uma conta <br> - Selecionar o tipo de usuário (instituição ou pessoal) <br> - Completar o cadastro conforme o tipo de usuário escolhido |
| **Critério de Êxito** 	| O sistema permite criar e gerenciar diferentes tipos de usuários. |

---

| **Caso de Teste** 	| **CT-04 – Editar perfil** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-04 - A aplicação deve permitir que o usuário edite seu perfil. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue editar as informações de seu perfil. |
| **Passos** 	| - Fazer login na aplicação <br> - Acessar a página de perfil <br> - Editar as informações desejadas (nome, foto, etc.) <br> - Clicar em "Salvar" |
| **Critério de Êxito** 	| As alterações no perfil são salvas corretamente. |

---

| **Caso de Teste** 	| **CT-05 – Cadastrar e gerenciar eventos** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-05 - A aplicação deve permitir que o usuário cadastre e gerencie eventos. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue criar e gerenciar eventos. |
| **Passos** 	| - Fazer login na aplicação <br> - Acessar a funcionalidade de eventos <br> - Preencher os detalhes do evento (nome, descrição, data, etc.) <br> - Salvar o evento <br> - Gerenciar eventos existentes (editar ou excluir) |
| **Critério de Êxito** 	| O evento foi criado e gerenciado com sucesso. |

---

| **Caso de Teste** 	| **CT-06 – Participar de eventos** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-06 - A aplicação deve permitir que os usuários entrem em eventos criados. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue participar de eventos criados. |
| **Passos** 	| - Fazer login na aplicação <br> - Navegar até a lista de eventos disponíveis <br> - Selecionar um evento <br> - Clicar em "Participar" |
| **Critério de Êxito** 	| O usuário foi adicionado ao evento com sucesso. |

---

| **Caso de Teste** 	| **CT-07 – Gerar relatórios de participação e impacto social** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-07 - A aplicação deve gerar relatórios de participação nos eventos e impacto social. |
| **Objetivo do Teste** 	| Verificar se o sistema gera relatórios corretos sobre a participação nos eventos e o impacto social. |
| **Passos** 	| - Fazer login como organizador <br> - Acessar a área de relatórios <br> - Gerar relatório de participação e impacto de um evento específico <br> - Visualizar o relatório gerado |
| **Critério de Êxito** 	| O relatório foi gerado com sucesso, com informações precisas de participação e impacto social. |

---

| **Caso de Teste** 	| **CT-08 – Receber notificações de eventos próximos** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-08 - A aplicação deve enviar notificações sobre eventos próximos. |
| **Objetivo do Teste** 	| Verificar se o usuário recebe notificações de eventos próximos. |
| **Passos** 	| - Fazer login na aplicação <br> - Cadastrar-se em um evento com data próxima <br> - Aguardar a notificação do evento próximo |
| **Critério de Êxito** 	| O usuário recebe a notificação corretamente antes do evento. |

---

| **Caso de Teste** 	| **CT-09 – Adicionar patrocinadores a eventos** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-09 - A aplicação deve permitir patrocinadores em eventos. |
| **Objetivo do Teste** 	| Verificar se o sistema permite adicionar patrocinadores aos eventos. |
| **Passos** 	| - Fazer login como organizador <br> - Criar um evento <br> - Adicionar um patrocinador ao evento <br> - Salvar as informações |
| **Critério de Êxito** 	| O patrocinador foi adicionado ao evento com sucesso. |

---

| **Caso de Teste** 	| **CT-10 – Gerar certificado de participação** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-10 - A aplicação deve gerar certificado de participação em evento. |
| **Objetivo do Teste** 	| Verificar se o sistema gera certificados de participação corretamente. |
| **Passos** 	| - Participar de um evento <br> - Aguardar o fim do evento <br> - Solicitar o certificado de participação <br> - Baixar o certificado gerado |
| **Critério de Êxito** 	| O certificado foi gerado corretamente e contém todas as informações necessárias. |

---

| **Caso de Teste** 	| **CT-11 – Personalizar tema/layout** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-11 - A aplicação deve permitir a personalização de temas ou layout pelos usuários. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue personalizar o tema ou layout da aplicação. |
| **Passos** 	| - Fazer login na aplicação <br> - Acessar a área de configurações <br> - Escolher o tema ou layout desejado <br> - Salvar as alterações |
| **Critério de Êxito** 	| O tema ou layout foi personalizado com sucesso e as mudanças foram aplicadas. |

---

| **Caso de Teste** 	| **CT-12 – Fornecer feedback ou avaliação do evento** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-12 - A aplicação deve permitir que usuários forneçam feedback ou avaliem os eventos após a participação. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue fornecer feedback ou avaliar um evento após participar. |
| **Passos** 	| - Participar de um evento <br> - Acessar a página do evento após sua conclusão <br> - Preencher o formulário de feedback ou avaliação <br> - Enviar o feedback/avaliação |
| **Critério de Êxito** 	| O feedback foi enviado com sucesso e aparece nas avaliações do evento. |

---

| **Caso de Teste** 	| **CT-13 – Acessar central de ajuda e FAQs** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-13 - A aplicação deve possuir uma central de ajuda e FAQs com tutoriais e documentação. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue acessar a central de ajuda e encontrar as FAQs. |
| **Passos** 	| - Fazer login na aplicação <br> - Acessar a central de ajuda <br> - Procurar por uma pergunta ou tutorial nas FAQs <br> - Visualizar o conteúdo relevante |
| **Critério de Êxito** 	| O usuário encontrou a informação necessária na central de ajuda e FAQs. |

---

| **Caso de Teste** 	| **CT-14 – Compartilhar eventos em redes sociais** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-14 - A aplicação deve permitir o compartilhamento de eventos em redes sociais. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue compartilhar eventos em redes sociais. |
| **Passos** 	| - Fazer login na aplicação <br> - Selecionar um evento <br> - Clicar na opção de compartilhar em redes sociais <br> - Escolher a rede social desejada e confirmar o compartilhamento |
| **Critério de Êxito** 	| O evento foi compartilhado com sucesso na rede social escolhida. |

---

| **Caso de Teste** 	| **CT-15 – Moderação de ações voluntárias** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-15 - A aplicação deve moderar a criação de ações voluntárias. |
| **Objetivo do Teste** 	| Verificar se a aplicação modera corretamente a criação de novas ações voluntárias. |
| **Passos** 	| - Fazer login como organizador <br> - Criar uma nova ação voluntária <br> - Enviar a ação para moderação <br> - Aguardar a aprovação ou reprovação da ação |
| **Critério de Êxito** 	| A ação foi corretamente moderada e aprovada/reprovada conforme as políticas da plataforma. |

---

| **Caso de Teste** 	| **CT-16 – Sugestão de eventos usando IA** 	|
|:---:	|:---:	|
| **Requisito Associado** 	| RF-16 - A aplicação deve utilizar IA para sugerir eventos ao usuário. |
| **Objetivo do Teste** 	| Verificar se o sistema sugere eventos relevantes ao usuário com base em IA. |
| **Passos** 	| - Fazer login na aplicação <br> - Navegar até a página de sugestões de eventos <br> - Visualizar os eventos sugeridos <br> - Avaliar a relevância das sugestões apresentadas |
| **Critério de Êxito** 	| A IA sugere eventos que correspondem aos interesses e ao histórico de participação do usuário. |

---

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
