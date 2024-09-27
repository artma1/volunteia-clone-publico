# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 


---

| **Caso de Teste**      | **CT-01 – Cadastrar perfil**                                                                                         |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-01 - A aplicação deve permitir que o usuário se cadastre.                                                          |
| **Objetivo do Teste**   | Verificar se o usuário consegue se cadastrar na aplicação.                                                            |
| **Passos**             | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
| **Critério de Êxito**   | O cadastro foi realizado com sucesso.                                                                                 |

| **Caso de Teste**      | **CT-02 – Realizar login**                                                                                             |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-02 - A aplicação deve permitir que o usuário realize login.                                                         |
| **Objetivo do Teste**   | Verificar se o usuário consegue fazer login na aplicação.                                                              |
| **Passos**             | - Acessar o site <br> - Informar o e-mail e a senha <br> - Clicar em "Entrar"                                           |
| **Critério de Êxito**   | O usuário foi autenticado com sucesso.                                                                                 |

| **Caso de Teste**      | **CT-03 – Criar diferentes tipos de usuários**                                                                         |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-03 - A aplicação deve permitir criar diferentes tipos de usuários (instituição, pessoal).                           |
| **Objetivo do Teste**   | Verificar se a aplicação permite criar diferentes tipos de usuários.                                                   |
| **Passos**             | - Acessar a página de cadastro <br> - Escolher o tipo de usuário (instituição ou pessoal) <br> - Completar o cadastro   |
| **Critério de Êxito**   | O usuário foi criado com o tipo selecionado.                                                                           |

| **Caso de Teste**      | **CT-04 – Editar perfil**                                                                                              |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-04 - A aplicação deve permitir que o usuário edite seu perfil.                                                      |
| **Objetivo do Teste**   | Verificar se o usuário consegue editar seu perfil.                                                                     |
| **Passos**             | - Fazer login <br> - Acessar o perfil <br> - Editar as informações desejadas <br> - Salvar as alterações                |
| **Critério de Êxito**   | As informações foram atualizadas com sucesso.                                                                          |

| **Caso de Teste**      | **CT-05 – Cadastrar e gerenciar eventos**                                                                               |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-05 - A aplicação deve permitir que o usuário cadastre e gerencie eventos.                                            |
| **Objetivo do Teste**   | Verificar se o usuário consegue cadastrar e gerenciar eventos.                                                          |
| **Passos**             | - Fazer login <br> - Acessar a área de eventos <br> - Criar um novo evento <br> - Editar ou excluir o evento criado      |
| **Critério de Êxito**   | O evento foi cadastrado, editado ou excluído com sucesso.                                                               |

| **Caso de Teste**      | **CT-06 – Participar de eventos**                                                                                       |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-06 - A aplicação deve permitir que os usuários entrem em eventos criados.                                            |
| **Objetivo do Teste**   | Verificar se o usuário consegue participar de eventos criados.                                                          |
| **Passos**             | - Fazer login na aplicação <br> - Navegar até a lista de eventos disponíveis <br> - Selecionar um evento <br> - Clicar em "Participar" |
| **Critério de Êxito**   | O usuário foi adicionado ao evento com sucesso.                                                                         |

| **Caso de Teste**      | **CT-07 – Gerar relatórios de participação e impacto social**                                                           |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-07 - A aplicação deve gerar relatórios de participação nos eventos e impacto social.                                 |
| **Objetivo do Teste**   | Verificar se o sistema gera relatórios corretos sobre a participação nos eventos e o impacto social.                    |
| **Passos**             | - Fazer login como organizador <br> - Acessar a área de relatórios <br> - Gerar relatório de participação e impacto de um evento específico <br> - Visualizar o relatório gerado |
| **Critério de Êxito**   | O relatório foi gerado com sucesso, com informações precisas de participação e impacto social.                          |

| **Caso de Teste**      | **CT-08 – Receber notificações de eventos próximos**                                                                    |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-08 - A aplicação deve enviar notificações sobre eventos próximos.                                                    |
| **Objetivo do Teste**   | Verificar se o usuário recebe notificações de eventos próximos.                                                         |
| **Passos**             | - Fazer login na aplicação <br> - Cadastrar-se em um evento com data próxima <br> - Aguardar a notificação do evento próximo |
| **Critério de Êxito**   | O usuário recebe a notificação corretamente antes do evento.                                                            |

| **Caso de Teste**      | **CT-09 – Adicionar patrocinadores a eventos**                                                                          |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-09 - A aplicação deve permitir patrocinadores em eventos.                                                           |
| **Objetivo do Teste**   | Verificar se o sistema permite adicionar patrocinadores aos eventos.                                                   |
| **Passos**             | - Fazer login como organizador <br> - Criar um evento <br> - Adicionar um patrocinador ao evento <br> - Salvar as informações |
| **Critério de Êxito**   | O patrocinador foi adicionado ao evento com sucesso.                                                                   |

| **Caso de Teste**      | **CT-10 – Gerar certificado de participação**                                                                           |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-10 - A aplicação deve gerar certificado de participação em evento.                                                  |
| **Objetivo do Teste**   | Verificar se o sistema gera certificados de participação corretamente.                                                 |
| **Passos**             | - Participar de um evento <br> - Aguardar o fim do evento <br> - Solicitar o certificado de participação <br> - Baixar o certificado gerado |
| **Critério de Êxito**   | O certificado foi gerado corretamente e contém todas as informações necessárias.                                        |

| **Caso de Teste**      | **CT-11 – Personalizar tema/layout**                                                                                    |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-11 - A aplicação deve permitir a personalização de temas ou layout pelos usuários.                                  |
| **Objetivo do Teste**   | Verificar se o usuário consegue personalizar o tema ou layout da aplicação.                                            |
| **Passos**             | - Fazer login na aplicação <br> - Acessar a área de configurações <br> - Escolher o tema ou layout desejado <br> - Salvar as alterações |
| **Critério de Êxito**   | O tema ou layout foi personalizado com sucesso e as mudanças foram aplicadas.                                           |

| **Caso de Teste**      | **CT-12 – Fornecer feedback ou avaliação do evento**                                                                    |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-12 - A aplicação deve permitir que usuários forneçam feedback ou avaliem os eventos após a participação.             |
| **Objetivo do Teste**   | Verificar se o usuário consegue fornecer feedback ou avaliar um evento após participar.                                 |
| **Passos**             | - Participar de um evento <br> - Acessar a página do evento após sua conclusão <br> - Preencher o formulário de feedback ou avaliação <br> - Enviar o feedback/avaliação |
| **Critério de Êxito**   | O feedback foi enviado com sucesso e aparece nas avaliações do evento.                                                  |

| **Caso de Teste**      | **CT-13 – Acessar central de ajuda e FAQs**                                                                             |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-13 - A aplicação deve possuir uma central de ajuda e FAQs com tutoriais e documentação.                              |
| **Objetivo do Teste**   | Verificar se o usuário consegue acessar a central de ajuda e encontrar as FAQs.                                         |
| **Passos**             | - Fazer login na aplicação <br> - Acessar a central de ajuda <br> - Navegar pelas FAQs ou tutoriais                      |
| **Critério de Êxito**   | O usuário encontrou a ajuda necessária através das FAQs ou tutoriais.                                                   |

| **Caso de Teste**      | **CT-14 – Solicitar exclusão de conta**                                                                                 |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-14 - A aplicação deve permitir a exclusão da conta do usuário.                                                      |
| **Objetivo do Teste**   | Verificar se o usuário consegue solicitar a exclusão de sua conta.                                                     |
| **Passos**             | - Fazer login na aplicação <br> - Acessar a área de configurações <br> - Solicitar a exclusão da conta <br> - Confirmar a solicitação |
| **Critério de Êxito**   | A conta do usuário foi excluída com sucesso.                                                                            |

| **Caso de Teste**      | **CT-15 – Moderar criação de ações voluntárias**                                                                         |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-15 - A aplicação deve moderar a criação de ações voluntárias.                                                      |
| **Objetivo do Teste**   | Verificar se o sistema permite a moderação na criação de ações voluntárias.                                            |
| **Passos**             | - Fazer login como moderador <br> - Acessar a seção de criação de ações voluntárias <br> - Submeter uma ação voluntária <br> - Revisar e aprovar ou rejeitar a criação |
| **Critério de Êxito**   | A ação voluntária foi moderada corretamente, sendo aprovada ou rejeitada conforme os critérios estabelecidos.          |

| **Caso de Teste**      | **CT-16 – Sugestão de eventos utilizando IA**                                                                            |
|:----------------------:|:----------------------------------------------------------------------------------------------------------------------:|
| **Requisito Associado** | RF-16 - A aplicação deve utilizar IA para sugerir eventos ao usuário.                                                  |
| **Objetivo do Teste**   | Verificar se o sistema sugere eventos adequados para o usuário com base em suas preferências.                         |
| **Passos**             | - Fazer login na aplicação <br> - Acessar a página de sugestões <br> - Visualizar os eventos sugeridos pela IA        |
| **Critério de Êxito**   | O sistema apresenta sugestões de eventos relevantes e personalizadas para o usuário.                                   |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
