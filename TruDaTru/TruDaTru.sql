/********************Competencia******************/
CREATE TABLE Competencia(
    Id INTEGER NOT NULL,
    Data_Competencia DATE NOT NULL,
    Ativo CHAR NOT NULL,
CONSTRAINT PK_Id_Competencia PRIMARY KEY(Id),
CONSTRAINT CK_Ativo_Competencia CHECK(Ativo = 'S' OR Ativo = 'N'), -- S = Sim, N = Não
CONSTRAINT UNQ_DT_Comp UNIQUE (Data_Competencia)
);

CREATE GENERATOR GEN_COMPETENCIA_ID;
SET GENERATOR GEN_COMPETENCIA_ID TO 0;

SET TERM ^;
CREATE TRIGGER TR_Auto_Id_Comp FOR Competencia
ACTIVE BEFORE INSERT position 0
AS
BEGIN
    new.id = gen_id(GEN_COMPETENCIA_ID,1);
END^
SET TERM ;^

/*******************Marca*************************/
CREATE TABlE Marca(
    Id INTEGER NOT NULL,
    Descricao VARCHAR(255) NOT NULL,
    Ativo CHAR NOT NULL,
CONSTRAINT PK_Id_Marca PRIMARY KEY(Id),
CONSTRAINT CK_Ativo_Marca CHECK(Ativo = 'S' OR Ativo = 'N') -- S = Sim, N = Não
);
CREATE GENERATOR GEN_MARCA_ID;
SET GENERATOR GEN_MARCA_ID TO 0;
SET TERM ^;
CREATE TRIGGER TR_Auto_Id_Marca FOR Marca
ACTIVE BEFORE INSERT position 0
AS
BEGIN
    new.id = gen_id(GEN_MARCA_ID,1);
END^
SET TERM ;^

/******************Produto**********************/
CREATE TABLE Produto(
    Id INTEGER NOT NULL,
    Descricao VARCHAR(255) NOT NULL,
    Ativo CHAR NOT NULL,
    Id_Marca INTEGER NOT NULL,
CONSTRAINT PK_Id_Produto PRIMARY KEY(Id),
CONSTRAINT FK_Prod_Marca FOREIGN KEY (Id_Marca) REFERENCES Marca(Id),
CONSTRAINT UNQ_Desc_Prod UNIQUE(Descricao),
CONSTRAINT CK_Ativo_Prod CHECK(Ativo = 'S' OR Ativo = 'N') -- S = Sim, N = Não
);
CREATE GENERATOR GEN_PRODUTO_ID;
SET GENERATOR GEN_PRODUTO_ID TO 0;
SET TERM ^;
CREATE TRIGGER TR_Auto_Id_Prod FOR Produto
ACTIVE BEFORE INSERT position 0
AS
BEGIN
    new.id = gen_id(GEN_PRODUTO_ID,1);
END^
SET TERM ;^

/*******************Estoque***********************/
CREATE TABLE Estoque(
    Id INTEGER NOT NULL,
    Tipo_ES CHAR NOT NULL,
    Data_Cadastro DATE NOT NULL,
    Qtd_Produto INTEGER DEFAULT 0 NOT NULL,
    Valor_Unitario DECIMAL(10,2) DEFAULT 0.00 NOT NULL,
    Id_Produto INTEGER NOT NULL,
    Id_Competencia INTEGER NOT NULL,
CONSTRAINT PK_Id_Estoque PRIMARY KEY(Id),
CONSTRAINT FK_Est_Prod FOREIGN KEY(Id_Produto) REFERENCES Produto(Id),
CONSTRAINT FK_Est_Comp FOREIGN KEY(Id_Competencia) REFERENCES Competencia(Id),
CONSTRAINT CK_Tipo_ES_Est CHECK(Tipo_ES = 'E' OR Tipo_ES = 'S' OR Tipo_ES = 'F') -- E = Entrada, S = Saida, F = Fechado
);
CREATE GENERATOR GEN_ESTOQUE_ID;
SET GENERATOR GEN_ESTOQUE_ID TO 0;
SET TERM ^;
CREATE TRIGGER TR_Auto_Id_Est FOR Estoque
ACTIVE BEFORE INSERT position 0
AS
BEGIN
    new.id = gen_id(GEN_ESTOQUE_ID,1);
END^
SET TERM;^

/*Criar view do Estoque*/
CREATE VIEW VW_Estoque
AS
    SELECT 
        E.Id AS Id_Estoque,
        C.Id AS Id_Competecia,
        M.Id AS Id_Marca,
        P.Id AS Id_Produto,
        C.Data_Competencia AS Competencia,
        M.Descricao AS Marca,
        P.Descricao AS Produto,
        E.Tipo_ES,
        E.Data_Cadastro AS Data_Cadastro,
        E.Qtd_Produto,
        E.Valor_Unitario,
        E.Qtd_Produto * E.Valor_Unitario AS Valor_Total
    FROM 
        Estoque E
    INNER JOIN Produto P ON E.Id_Produto = P.Id
    INNER JOIN Competencia C ON E.Id_Competencia = C.Id
    INNER JOIN Marca M ON P.Id_Marca = M.Id
