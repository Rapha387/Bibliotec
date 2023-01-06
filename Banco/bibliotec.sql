DROP SCHEMA IF EXISTS Bibliotec;
CREATE SCHEMA Bibliotec;
USE Bibliotec;

DROP TABLE IF EXISTS editora;

CREATE TABLE  editora 
(
  cd_editora INT,
  nm_editora VARCHAR(200),
  CONSTRAINT pk_editora PRIMARY KEY (cd_editora) 
);

CREATE TABLE  livro 
(
  cd_livro INT,
  cd_ISBN VARCHAR(200),
  nm_livro TEXT,
  aa_edicao INT,
  ds_sinopse TEXT,
  cd_editora INT,
  capa longblob,
  CONSTRAINT pk_livro PRIMARY KEY (cd_livro),
  CONSTRAINT fk_livro_editora1 FOREIGN KEY (cd_editora)
    REFERENCES editora (cd_editora)
);

CREATE TABLE  autor 
(
  cd_autor INT,
  nm_autor VARCHAR(200),
  CONSTRAINT pk_autor PRIMARY KEY (cd_autor) 
);

CREATE TABLE  categoria 
(
  cd_categoria INT,
  nm_categoria VARCHAR(200),
  CONSTRAINT pk_categoria PRIMARY KEY (cd_categoria) 
);

CREATE TABLE  livro_categoria 
(
  cd_livro INT,
  cd_categoria INT,
  CONSTRAINT pk_livro_cat PRIMARY KEY (cd_livro, cd_categoria) ,
  CONSTRAINT fk_livro_categoria_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_livro_categoria_categoria1 FOREIGN KEY (cd_categoria)
    REFERENCES categoria (cd_categoria)
);

CREATE TABLE  localizacao 
(
  cd_localizacao INT,
  nm_localizacao VARCHAR(255),
  CONSTRAINT pk_localizacao PRIMARY KEY (cd_localizacao)
);

CREATE TABLE  exemplar 
(
  cd_exemplar INT,
  cd_livro INT,
  ic_fixo TINYINT(1),
  cd_localizacao INT,
  CONSTRAINT pk_exemplar PRIMARY KEY (cd_exemplar, cd_livro),
  CONSTRAINT fk_exemplar_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_exemplar_localizacao1 FOREIGN KEY (cd_localizacao)
    REFERENCES localizacao (cd_localizacao)
);


CREATE TABLE  tipo_usuario 
(
  cd_tipo_usuario INT,
  nm_tipo_usuario VARCHAR(45),
  CONSTRAINT pk_tipo_usuario PRIMARY KEY (cd_tipo_usuario)
);

CREATE TABLE  usuario 
(
  nm_login VARCHAR(200),
  nm_usuario VARCHAR(255),
  nm_senha VARCHAR(64),
  ic_bloqueado TINYINT(1),
  dt_bloqueio DATE,
  cd_tipo_usuario INT,
  CONSTRAINT pk_usuario PRIMARY KEY (nm_login),
  CONSTRAINT fk_usuario_tipo_usuario1 FOREIGN KEY (cd_tipo_usuario)
    REFERENCES tipo_usuario (cd_tipo_usuario)
);

CREATE TABLE  tipo_emprestimo 
(
  cd_tipo_emprestimo INT,
  nm_tipo_emprestimo VARCHAR(45),
  CONSTRAINT pk_tipo_emp PRIMARY KEY (cd_tipo_emprestimo)
);

CREATE TABLE  emprestimo 
(
  nm_login VARCHAR(200),
  cd_exemplar INT,
  cd_livro INT,
  dt_emprestimo DATE,
  hr_emprestimo TIME,
  dt_devolucao_estimada DATE,
  dt_devolucao DATE,
  cd_tipo_emprestimo INT,
  CONSTRAINT pk_emp PRIMARY KEY (nm_login, cd_exemplar, cd_livro, dt_emprestimo),
  CONSTRAINT fk_usuario_exemplar_usuario1 FOREIGN KEY (nm_login)
    REFERENCES usuario (nm_login),
  CONSTRAINT fk_usuario_exemplar_exemplar1 FOREIGN KEY (cd_exemplar , cd_livro)
    REFERENCES exemplar (cd_exemplar , cd_livro),
  CONSTRAINT fk_emprestimo_tipo_emprestimo1 FOREIGN KEY (cd_tipo_emprestimo)
    REFERENCES tipo_emprestimo (cd_tipo_emprestimo)
);

CREATE TABLE  tipo_ocorrencia 
(
  cd_tipo_ocorrencia INT,
  nm_tipo_ocorrencia VARCHAR(45),
  CONSTRAINT pk_tipo_ocorrencia PRIMARY KEY (cd_tipo_ocorrencia)
);

CREATE TABLE  ocorrencia 
(
  nm_login VARCHAR(200),
  cd_exemplar INT,
  cd_livro INT,
  dt_emprestimo DATE,
  cd_tipo_ocorrencia INT,
  ds_ocorrencia TEXT,
  CONSTRAINT pk_ocorrencia PRIMARY KEY (nm_login, cd_exemplar, cd_livro, dt_emprestimo, cd_tipo_ocorrencia) ,
  CONSTRAINT fk_emprestimo_tipo_ocorrencia_emprestimo1 FOREIGN KEY (nm_login , cd_exemplar , cd_livro , dt_emprestimo)
    REFERENCES emprestimo (nm_login , cd_exemplar , cd_livro , dt_emprestimo),
  CONSTRAINT fk_emprestimo_tipo_ocorrencia_tipo_ocorrencia1 FOREIGN KEY (cd_tipo_ocorrencia)
    REFERENCES tipo_ocorrencia (cd_tipo_ocorrencia)
);

CREATE TABLE  computador 
(
  dt_uso_computador DATE,
  nm_login VARCHAR(200),
  CONSTRAINT pk_computador PRIMARY KEY (dt_uso_computador, nm_login) ,
  CONSTRAINT fk_computador_usuario1 FOREIGN KEY (nm_login)
    REFERENCES usuario (nm_login)
);

CREATE TABLE  livro_autor 
(
  cd_livro INT,
  cd_autor INT,
  CONSTRAINT pk_livro_autor PRIMARY KEY (cd_livro, cd_autor),
  CONSTRAINT fk_livro_autor_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_livro_autor_autor1 FOREIGN KEY (cd_autor)
    REFERENCES autor (cd_autor)
);

INSERT INTO editora (cd_editora, nm_editora) VALUES (1, 'Editora FTD');
INSERT INTO editora (cd_editora, nm_editora) VALUES (2, 'Editora JBL');
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (1, '8532223796', 'Matematica - V. 3 - Geometria Analitica, Numeros Complexos E Polinomio', 2021, NULL, 1 , null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (2, '7832710376', 'Química - V. 1 - Química Organica', 2020, 'essa é uma sinopse de química que vamos falar de química organica, onde tem muita química', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (3, '4854485493', 'Geografia - V. 1 - Tipos de Relevo', 2021, 'Um relevo é o produto da ação de diversos agentes externos e internos que dão origem a uma forma rochosa, podendo ser ela uma planície, planalto depressão ou montanha.', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (4, '5612993845', 'Filosofia - V. 1 - Aristóteles', 2022, 'Aristóteles foi um filósofo grego durante o período clássico na Grécia antiga', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (5, '6949549854', 'Fisíca- V. 4- Refração', 2021, 'Refração é a mudança na velocidade de uma onda ao atravessar a fronteira entre dois meios com diferentes índices de refração. ', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (6, '5485449830', 'Matematica - V. 2 - Progressão Artimética', 2021, 'Uma progressão aritmética é uma sequência numérica em que cada termo, a partir do segundo, é igual à soma do termo anterior com uma constante', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (7, '4545569594', 'Lingua Portuguesa - V. 3 - Romantismo', 2019, 'O romantismo foi um movimento artístico, político e filosófico surgido nas últimas décadas do século XVIII na Europa que durou por grande parte do século XIX.', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (8, '9756565675', 'Filosofia - V. 1 - Filosofia na Arte ', 2022, 'Filosofia da arte se dedica a compreender essa campo da atividade humana que lida com a afetação', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (9, '4546565767', 'Biologia - V. 2 - Sistema Reprodutor', 2020, 'O aparelho reprodutor, sistema reprodutor ou sistema genital é um sistema de órgãos dentro de um organismo que trabalham em conjunto com a finalidade de reprodução.', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (10, '7643545546', 'Biologia - V. 1 - Sistema Cardiovascular', 2022, 'O sistema circulatório é o conjunto de órgãos responsáveis pela distribuição de nutrientes para as células e coleta de suas excretas metabólicas para serem eliminadas por órgãos excretores.', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (11, '8796655443', 'Sociologia - V. 2 - Mudanças na Sociedade', 2021, 'Transformação social significa a mudança da sociedade e do seu modo de organização.', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (12, '2454545656', 'Lingua Portuguesa - V. 3 - Naturalismo', 2022, 'O naturalismo é um movimento artístico e literário conhecido por ser a radicalização do realismo.', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (13, '1456576664', 'Química - V. 2 - Osmose', 2022, 'A osmose é o movimento de água através de uma membrana semipermeável ocasionado por diferenças na pressão osmótica.', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (14, '5678765432', 'Filosofia - V. 1 - Emanuel Kant ', 2022, 'Immanuel Kant foi um filósofo prussiano. Amplamente considerado como o principal filósofo da era moderna, Kant operou, na epistemologia, uma síntese entre o racionalismo continental, e a tradição empírica inglesa.', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (15, '5346573464', 'Fisíca - V. 2 - Espelhos', 2022, 'Espelhos planos são sistemas ópticos de espelhos constituídos por superfícies planas e polidas, capazes de refletir regularmente a luz, como acontece com a superfície do mercúrio em equilíbrio ', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (16, '9087566756', 'Sociologia - V. 3 - Karl Marx', 2021, 'Karl Marx foi um filósofo, economista, historiador, sociólogo, teórico político, jornalista, e revolucionário socialista alemão', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (17, '3854755749', 'Ingles - V. 1 - Present Simple', 2021, ' presente simples, presente simples ou presente indefinido é uma das formas verbais associadas ao tempo presente no inglês moderno.', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (18, '1047593923', 'Ingles - V. 2 -  Verbos Regulares E Irregulares', 2019, 'Regra geral, aqueles que seguem uma conjugação padrão de terminações são os chamados verbos regulares. Os verbos irregulares são aqueles que não seguem um modelo de conjugação e, portanto, costumam ser mais complicados para os estudantes.', 2, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (19, '4867595284', 'História - V. 1 - Egito Antigo', 2022, 'O Antigo Egito foi uma civilização do Antigo Oriente Próximo do Norte de África, concentrada ao longo ao curso inferior do rio Nilo, no que é hoje o país moderno do Egito.', 1, null);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, capa) VALUES (20, '7895893425', 'História - V. 2 - Mesopotamia', 2022, 'A Mesopotâmia é a área do sistema fluvial Tigre-Eufrates, o que nos dias modernos corresponde a aproximadamente à maior parte do atual Iraque e Kuwait', 1, null);
INSERT INTO autor (cd_autor, nm_autor) VALUES (1, 'Regina Giovanni');
INSERT INTO autor (cd_autor, nm_autor) VALUES (2, 'Jose Ruy Bonjorno');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (1, 'Lingua Portuguesa');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (2, 'Biologia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (3, 'História');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (4, 'Filosofia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (5, 'Química');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (6, 'Geografia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (7, 'Matemática');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (8, 'Física');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (9, 'Sociologia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (10, 'Inglês');
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (1, 7);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (2, 5);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (3, 6);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (5, 8);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (6, 7);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (7, 1);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (8, 4);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (9, 2);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (10, 2);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (11, 9);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (12, 1);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (13, 5);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (14, 4);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (15, 8);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (16, 9);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (17, 10);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (18, 10);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (19, 3);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (20, 3);
INSERT INTO localizacao (cd_localizacao, nm_localizacao) VALUES (1, 'E02C01P01 - Estante 02 - Coluna 01 - Prateleira 01');
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 1, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 1, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 2, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 2, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 3, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 3, 0, 1);
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (1, 'Admin');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (2, 'Operador');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (3, 'Cliente');
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('admin', 'Administrador', '123', 0, NULL, 1);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('operador', 'Operador', '123', 0, NULL, 2);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('12577', 'Frederico Arco e Flexa Machado Justo', '123', 1, "2022-02-15", 3);
INSERT INTO tipo_emprestimo (cd_tipo_emprestimo, nm_tipo_emprestimo) VALUES (1, 'Consulta');
INSERT INTO tipo_emprestimo (cd_tipo_emprestimo, nm_tipo_emprestimo) VALUES (2, 'Empréstimo');
INSERT INTO tipo_ocorrencia (cd_tipo_ocorrencia, nm_tipo_ocorrencia) VALUES (1, 'Devolução com leve dano');
INSERT INTO tipo_ocorrencia (cd_tipo_ocorrencia, nm_tipo_ocorrencia) VALUES (2, 'Devolução com grave dano');
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (1, 1);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (1, 2);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (2, 1);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (3, 2);
