# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 


---

|                       **Caso de Teste**                        |                 **CT-01 – Cadastrar perfil**                  |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-01 - A aplicação deve permitir que o usuário se cadastre.   |
|                       **Objetivo do Teste**                     | Verificar se o usuário consegue se cadastrar na aplicação.      |
|                         **Passos**                               | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|                     **Critério de Êxito**                       | O cadastro foi realizado com sucesso.                           |

|                       **Caso de Teste**                        |                 **CT-02 – Realizar login**                     |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-02 - A aplicação deve permitir que o usuário realize login.  |
|                       **Objetivo do Teste**                     | Verificar se o usuário consegue realizar login na aplicação.     |
|                         **Passos**                               | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Preencher e-mail e senha <br> - Clicar em "Entrar" |
|                     **Critério de Êxito**                       | O login foi realizado com sucesso e o usuário é redirecionado. |

|                       **Caso de Teste**                        |                 **CT-03 – Criar diferentes tipos de usuários**  |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-03 - A aplicação deve permitir criar diferentes tipos de usuários. |
|                       **Objetivo do Teste**                     | Verificar se diferentes tipos de usuários podem ser criados.     |
|                         **Passos**                               | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher dados do usuário <br> - Selecionar tipo de usuário <br> - Clicar em "Registrar" |
|                     **Critério de Êxito**                       | O tipo de usuário foi criado corretamente.                      |

|                       **Caso de Teste**                        |                 **CT-04 – Editar perfil**                       |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-04 - A aplicação deve permitir que o usuário edite seu perfil. |
|                       **Objetivo do Teste**                     | Verificar se o usuário consegue editar seu perfil.              |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Clicar em "Meu perfil" <br> - Alterar dados do perfil <br> - Clicar em "Salvar alterações" |
|                     **Critério de Êxito**                       | As alterações no perfil foram salvas com sucesso.              |

|                       **Caso de Teste**                        |                 **CT-05 – Gerenciar eventos**                   |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-05 - A aplicação deve permitir que o usuário cadastre e gerencie eventos. |
|                       **Objetivo do Teste**                     | Verificar se o usuário consegue cadastrar e gerenciar eventos.   |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Clicar em "Criar evento" <br> - Preencher dados do evento <br> - Clicar em "Salvar" |
|                     **Critério de Êxito**                       | O evento foi cadastrado e está visível na lista de eventos.     |

|                       **Caso de Teste**                        |                 **CT-06 – Participar de eventos**               |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-06 - A aplicação deve permitir que os usuários entrem em eventos criados. |
|                       **Objetivo do Teste**                     | Verificar se o usuário consegue participar de eventos.          |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Navegar pelos eventos <br> - Clicar em "Participar" em um evento <br> - Confirmar participação |
|                     **Critério de Êxito**                       | O usuário foi adicionado com sucesso ao evento.                |

|                       **Caso de Teste**                        |                 **CT-07 – Gerar relatórios**                   |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-07 - A aplicação deve gerar relatórios de participação nos eventos e impacto social. |
|                       **Objetivo do Teste**                     | Verificar se os relatórios são gerados corretamente.            |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Navegar até a seção de relatórios <br> - Selecionar evento <br> - Clicar em "Gerar relatório" |
|                     **Critério de Êxito**                       | O relatório foi gerado e está disponível para visualização.    |

|                       **Caso de Teste**                        |                 **CT-08 – Notificações de eventos**            |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-08 - A aplicação deve enviar notificações sobre eventos próximos. |
|                       **Objetivo do Teste**                     | Verificar se as notificações são enviadas corretamente.          |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Aguardar notificações <br> - Verificar se a notificação é recebida |
|                     **Critério de Êxito**                       | As notificações são recebidas a tempo.                          |

|                       **Caso de Teste**                        |                 **CT-09 – Patrocinadores em eventos**         |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-09 - A aplicação deve permitir patrocinadores em eventos.    |
|                       **Objetivo do Teste**                     | Verificar se os patrocinadores podem ser adicionados a eventos.  |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Criar evento <br> - Adicionar patrocinador <br> - Clicar em "Salvar" |
|                     **Critério de Êxito**                       | O patrocinador foi adicionado ao evento com sucesso.            |

|                       **Caso de Teste**                        |                 **CT-10 – Gerar certificado**                  |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-10 - A aplicação deve gerar certificado de participação em evento. |
|                       **Objetivo do Teste**                     | Verificar se o certificado é gerado corretamente.                |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Participar de evento <br> - Clicar em "Gerar certificado" |
|                     **Critério de Êxito**                       | O certificado foi gerado e pode ser baixado.                   |

|                       **Caso de Teste**                        |                 **CT-11 – Personalização de temas**           |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-11 - A aplicação deve permitir a personalização de temas ou layout pelos usuários. |
|                       **Objetivo do Teste**                     | Verificar se o usuário pode personalizar o tema da aplicação.    |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Navegar até configurações <br> - Escolher tema <br> - Clicar em "Salvar" |
|                     **Critério de Êxito**                       | O tema foi alterado e aplicado com sucesso.                     |

|                       **Caso de Teste**                        |                 **CT-12 – Feedback dos eventos**               |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-12 - A aplicação deve permitir que usuários forneçam feedback ou avaliem os eventos após a participação. |
|                       **Objetivo do Teste**                     | Verificar se os usuários podem deixar feedback após os eventos.   |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Navegar até o evento <br> - Preencher avaliação |
|                     **Critério de Êxito**                       | O feedback foi registrado com sucesso.                          |

|                       **Caso de Teste**                        |                 **CT-13 – Central de ajuda**                   |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-13 - A aplicação deve possuir uma central de ajuda e FAQs com tutoriais e documentação. |
|                       **Objetivo do Teste**                     | Verificar se a central de ajuda é acessível e funcional.        |
|                         **Passos**                               | - Acessar o navegador <br> - Navegar até "Ajuda" <br> - Clicar em tutoriais <br> - Navegar pelas FAQs |
|                     **Critério de Êxito**                       | A central de ajuda carrega corretamente e está acessível.       |

|                       **Caso de Teste**                        |                 **CT-14 – Compartilhar eventos**               |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-14 - A aplicação deve permitir o compartilhamento de eventos em redes sociais. |
|                       **Objetivo do Teste**                     | Verificar se o compartilhamento de eventos funciona corretamente. |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Navegar pelos eventos <br> - Clicar em "Compartilhar" <br> - Selecionar rede social |
|                     **Critério de Êxito**                       | O evento foi compartilhado com sucesso.                         |

|                       **Caso de Teste**                        |                 **CT-15 – Moderação de ações voluntárias**     |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-15 - A aplicação deve moderar a criação de ações voluntárias. |
|                       **Objetivo do Teste**                     | Verificar se a moderação funciona adequadamente.                |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Criar ação voluntária <br> - Submeter para moderação |
|                     **Critério de Êxito**                       | A ação voluntária foi submetida e está aguardando moderação.    |

|                       **Caso de Teste**                        |                 **CT-16 – Sugestão de eventos pela IA**       |
|:---------------------------------------------------------------:|:---------------------------------------------------------------:|
|                         **Requisito Associado**                 | RF-16 - A aplicação deve utilizar IA para sugerir eventos ao usuário. |
|                       **Objetivo do Teste**                     | Verificar se a IA sugere eventos corretamente.                 |
|                         **Passos**                               | - Acessar o navegador <br> - Realizar login <br> - Navegar até sugestões <br> - Verificar eventos sugeridos |
|                     **Critério de Êxito**                       | As sugestões de eventos aparecem corretamente.                 |
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
