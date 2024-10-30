 A aplicação virtual do projeto SmartAir, desenvolvida inteiramente com o formato WPF.NET, via Visual
 Studio, é composta por um total de 6 janelas principais. Em ordem respectiva, as janelas representam:

- Tela inicial (loading ou carregamento);
- Tela de Login de Usuário (onde usuários cadastrados poderão acessar a página seguinte);
- Tela de Menu principal (onde estarão dispostos os acessos ao gerenciamento dos ares-condicionados
dos laboratórios, anfiteatro e demais ambientes a serem adicionados, além de outras opções de display);
- Tela de Cadastro de Usuário (onde os usuários não cadastrados poderão cadastrar seus dados);
- Tela de Cadastro de ESP (onde ESPs de futuros ambientes poderão ser adicionados ao catálogo de gerenciamento);
- Tela de Cadastro de Laboratório (onde futuros novos laboratórios também poderão ser cadastrados para o
gerenciamento dos ESPs/ares-condicionados).

  Haverá ainda outras janelas-acessórios que contarão com o controle de gerenciamento dos ares-condicionados e 
indicativo de temperatura ambiente, as quais serão desenvolvidas posteriormente e poderão ser acessadas via menu
principal.

  Excetuando a tela inicial, todas as outras janelas estão conectadas com o banco de dados desenvolvido no contexto
interdisciplinar com a matéria de BD, orientada pela professora Priscila Martins. No código, cada etapa do banco de dados
e sua respectiva função estão integrados de acordo com a finalidade de cada janela.

  No que tange ao C#, este por sua vez é representado não somente pela linguagem predominante no desenvolvimento da
aplicação, como também pela utilização de fundamentos apresentados nas aulas de DS, ministradas pelo professor Rafael
de Colle. No back-end das janelas, conceitos como classes de modelagem, cordiais às entidades do banco de dados outrora
criado e distribuídas entre construtores (vazios/com parâmetros) métodos get-set (encapsulamento) para os atributos
(excetuando apenas o requisito da herança pelo fato de a proposta do projeto não contemplar uma classe base capaz de gerar
classes derivadas).

  As janelas apresentam também classes para Connection Factory, com o intuito de estabelecer e gerenciar a conexão com o BD
no MySQL. Além disso, o projeto apresenta, em cada classe de modelagem, classes de Data Access Object para que haja uma
comunicação funcional entre a aplicação e o banco de dados. Isso está vigente principalmente nas telas que remetem ao cadastro,
seja de dispositivos, ambientes ou usuários, e na tela de login.

  Por fim, o projeto possui uma etapa integrada ao ESP32, que será explicada e demonstrada por meio de uma adaptação com a placa
de Arduino Uno, apesar de apresentar um contexto similar.
