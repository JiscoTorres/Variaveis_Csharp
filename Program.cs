// Para criar um projeto C# no terminal =  dotnet new console -o  nome_do_projeto
// Vírgula no C# é obrigatória!
// Identação é um padrão importante para seguir!
//CURSO C# - JOÃO FRANCISCO TORRES.



//                                     TIPOS DE VARIÁVEIS

/* 
----------------------------------------------1°-----------------------------------------------------
                                             INT

Usada para armezanar dados de números inteiros, sendo eles tanto positivos quanto negativos.
- EXs: 
int idade_da_minha_irma = 22;
int temperatura_mais_baixa = -12;
int Ano_de_inicio_da_guerra_do_viatina = 1945;
-----------------------------------------------------------------------------------------------------

----------------------------------------------2°----------------------------------------------------
                                            FLOAT

Armazena dados de númeos decimais. Podendo armazenar números positivos e negativos. 
Diferente de DOUBLE e DECIMAL. SEMPRE COLOCAR UM "f" no final do valor.
- EXs: 
float valor_que_estou_devendo = 20.50f;
float quanto_perdi_na_aposta = -1234.654f;
-----------------------------------------------------------------------------------------------------

----------------------------------------------3°----------------------------------------------------
                                             BOOL

Tipo de dado Booleano só pode ter dois valores -> True ou False.
- EXs: 
bool Eu_gosto_de_HarryPotter = true;
bool Bebi_agua_hoje = false;
-----------------------------------------------------------------------------------------------------

----------------------------------------------4°----------------------------------------------------
                                            STRING

Tipos de dados declarados com aspas duplas("") sendo do tipo texto; 
podendo conter letras, número e caracteres.
- EXs: 
string MyNameIs = "João Francisco Torres";
string em_que_ano_estamos = "2022";
string MyDogsNameIs = "Mulan";
string Duas_Primeiras_Letras_Do_Alfabeto = "ab";
-----------------------------------------------------------------------------------------------------

----------------------------------------------5°----------------------------------------------------
                                             CHAR

Tipos de dados declarados com ''(aspas simples), onde se armazenam apenas 1 único caracter.
- EXs:
char NotaDaProva = 'A';
char Temporada_favorita_de_StrangerThings = '4';
-----------------------------------------------------------------------------------------------------

----------------------------------------------6°----------------------------------------------------
                                           DYNAMIC

Pode-se declarar uma variável do tipo Dynamic que permite que a variável possa ter seu tipo alterado.

- EX:

    dynamic temporada_favorita_de_StrangerThings = "Quarta"; //criar a variável, nesse caso criou no formato String
    Console.WriteLine(temporada_favorita_de_StrangerThings); // fazer a variável aparecer no console, irá aparecer "Quarta" no console

    temporada_favorita_de_StrangerThings = 4; //modificou para o formato int
    Console.WriteLine(temporada_favorita_de_StrangerThings);// fazer a variável aparecer no console, agora irá aparecer "4" no console
-----------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------
                                  FLOAT |VS| DOUBLE |VS| DECIMAL

Em suma, a diferença entre esse três tipos de variáveis está na questão de quantidade 
de números decimais.
_____________________________________________________________________________________________________

- FLOAT X DOUBLE
A diferença entre o float e o double é a precisão, ou seja, o quanto varia, o quanto consegue 
expressar um valor próximo do real, é o número de casas decimais que ele consegue suportar.
DOUBLE É O MAIS UTILIZADO!


EX double:
double NumeroPI_Double = 3.1415923565323846;
Console.WriteLine(NumeroPI_Double);

---> No console sairá o valor 3.14159235653238

EX float:
float NumeroPI_Float = 3.1415923565323846f;
Console.WriteLine(NumeroPI_Float);

---> No console sairá o valor 3.141592


Logo, pode-se concluir que é melhor utilizar "Double" porque ele contém um ALCANCE de precisão MAIOR!
_____________________________________________________________________________________________________

- DECIMAL
O tipo decimal tem exatidão, ele é sobre ter o número exato que se pretende. 
Ele indica que o número está em conformidade com o que se espera. 
Ele chama decimal por ter base 10 e não binária como os anteriores.                                 
-----------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------
                                          NOMEANDO VARIÁVEIS 

- Padrões para  a variável Segunda Guerra Mundial:
int Segunda_Guerra_Mundial  =;
int SegundaGuerraMundial =;
______________________________________________________________________________________________________

REGRAS para não cometer erros:

1°) Não se pode utilizar caracteres especiais no nome.
-EX: int $egund@Guerr@Mundi@l = 1;

2°) O PRIMEIRO caracter do nome da váriável não pode ser um número.
-EX: int 2GuerraMundial = ;

3°) Não de pode espaçar em nome de variáveis.
-EX: int segunda guerra mundial = ;

4°) Precisa conter caracteres de A-Z.

-----------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------
                                   MODIFICANDO OS VALORES DAS VARIÁVEIS

No C# é possível modificar o valor de uma variável sem precisar declará-la novamente.
_____________________________________________________________________________________________________
-EX 1: 

        string Cor_Favorita = "Rosa"; //declarou uma variável do tipo String
        Console.WriteLine(Cor_Favorita); //aparecerá "Rosa" no console

        Cor_Favorita = "Amarelo"; //definiu um novo valor para a variável, sem declara-lá de novo.
        Console.WriteLine(Cor_Favorita); //aparecerá "Amarelo" no console
_____________________________________________________________________________________________________

-EX 2:
        double VelocidadeDoCarro = 234.1234; //declarou uma variável do tipo Double
        Console.WriteLine(VelocidadeDoCarro); //aparecerá "234.1234" no console

        VelocidadeDoCarro = 8765.4325
        Console.WriteLine(VelocidadeDoCarro); //aparecerá "8765.4325" no console
_____________________________________________________________________________________________________

-EX 3: Neste exemplo, foram modificados tanto o valor da variável quanto o tipo dela!

    dynamic temporada_favorita_de_StrangerThings = "Quarta"; //criar a variável, nesse caso criou no formato String
    Console.WriteLine(temporada_favorita_de_StrangerThings); // fazer a variável aparecer no console, irá aparecer "Quarta" no console

    temporada_favorita_de_StrangerThings = 4; //modificou para o formato int
    Console.WriteLine(temporada_favorita_de_StrangerThings);// fazer a variável aparecer no console, agora irá aparecer "4" no console

_____________________________________________________________________________________________________


-----------------------------------------------------------------------------------------------------
                                     
/*



