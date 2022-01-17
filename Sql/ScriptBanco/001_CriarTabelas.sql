CREATE TABLE pais(
    cd_pais int NOT NULL,
	nr_pais varchar(2),
	ds_pais varchar(50),    
	PRIMARY KEY (cd_pais));	

CREATE TABLE estado(
    cd_estado int NOT NULL,
    sg_estado varchar(4),  
	ds_estado varchar(50),  
	cd_pais   int NOT NULL, 	
	PRIMARY KEY (cd_estado));
ALTER TABLE estado  WITH CHECK ADD CONSTRAINT [fk_pais] FOREIGN KEY(cd_pais) REFERENCES pais (cd_pais);

CREATE TABLE cidade(
    cd_cidade int NOT NULL,		
	ds_cidade varchar(50), 
	nr_ibge   nvarchar(10),  	
	cd_estado int NOT NULL,
	cd_pais int NOT NULL,	
	PRIMARY KEY (cd_cidade));
ALTER TABLE estado  WITH CHECK ADD CONSTRAINT [fk_estado_1] FOREIGN KEY(cd_estado) REFERENCES estado (cd_estado);
ALTER TABLE pais  WITH CHECK ADD CONSTRAINT [fk_estado_2] FOREIGN KEY(cd_pais) REFERENCES pais (cd_pais);


CREATE TABLE tipo_usuario(
	cd_tipo_usuario int NOT NULL,	
	ds_tipo_usuario nvarchar(50) NOT NULL,
	PRIMARY KEY (cd_tipo_usuario)	
)

CREATE TABLE usuario(
	cd_usuario       int NOT NULL,		
	fl_ativo         char(1) NOT NULL DEFAULT 'S',	
	nm_usuario       nvarchar(50) NOT NULL,	
	ds_estado_civil  nvarchar(15),	
	dt_nascimento    datetime,
	ds_senha         nvarchar(50) NOT NULL,
	cd_cidade        int,	
	cd_tipo_usuario  int NOT NULL,		
	PRIMARY KEY (cd_usuario)	
)
ALTER TABLE usuario  ADD CONSTRAINT fk_cd_cidade    FOREIGN KEY(cd_cidade) REFERENCES cidade (cd_cidade)
ALTER TABLE usuario  WITH CHECK ADD CONSTRAINT fk_tipo_usuario FOREIGN KEY(cd_tipo_usuario) REFERENCES tipo_usuario (cd_tipo_usuario)


CREATE TABLE tipo_aeronave(
	cd_tipo_aeronave int NOT NULL,	
	ds_tipo_aeronave nvarchar(50) NOT NULL,
	PRIMARY KEY (cd_tipo_aeronave)	
)

CREATE TABLE aeronave(
	cd_aeronave      int NOT NULL, 	
	nr_aeronave      nvarchar(20) NOT NULl,
    ds_aeronave      nvarchar(50) NOT NULl,	
	cd_tipo_aeronave int NOT NULL,	   	
	PRIMARY KEY (cd_aeronave)	
)
ALTER TABLE aeronave  WITH CHECK ADD CONSTRAINT fk_tipo_aeronave FOREIGN KEY(cd_tipo_aeronave) REFERENCES tipo_aeronave (cd_tipo_aeronave)


CREATE TABLE tipo_departamento(
	cd_tipo_departamento  int NOT NULL,    
	ds_tipo_departamento  nvarchar(50) NOT NULl,	    
	PRIMARY KEY (cd_tipo_departamento)	
)

CREATE TABLE departamento(
	cd_departamento       int NOT NULL, 	
	ds_departamento       nvarchar(50) NOT NULl,	    
	cd_tipo_departamento  int NOT NULL, 
	PRIMARY KEY (cd_departamento)	
)
ALTER TABLE departamento  WITH CHECK ADD CONSTRAINT fk_tipo_departamento FOREIGN KEY(cd_tipo_departamento) REFERENCES tipo_departamento (cd_tipo_departamento)


CREATE TABLE tipo_telefone(
	cd_tipo_telefone  int NOT NULL,    	
    ds_tipo_telefone  nvarchar(20) NOT NULl,	
	PRIMARY KEY (cd_tipo_telefone)	
)

CREATE TABLE telefone(
	cd_telefone      int NOT NULL,    	    
	nr_codigo_area   nvarchar(20) NOT NULl,
	nr_telefone      nvarchar(20) NOT NULl,
	cd_tipo_telefone int NOT NULL,    	
	PRIMARY KEY (cd_telefone)	
)
ALTER TABLE telefone  WITH CHECK ADD CONSTRAINT fk_tipo_telefone FOREIGN KEY(cd_tipo_telefone) REFERENCES tipo_telefone (cd_tipo_telefone)


CREATE TABLE usuario_telefone(
    cd_usuario_telefone int NOT NULL,
	cd_telefone         int NOT NULL,
    cd_usuario          int NOT NULL,	    
	PRIMARY KEY (cd_usuario_telefone)	
)
ALTER TABLE usuario_telefone  WITH CHECK ADD CONSTRAINT fk_usuario_telefone_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_telefone  WITH CHECK ADD CONSTRAINT fk_usuario_telefone_2 FOREIGN KEY(cd_telefone) REFERENCES telefone (cd_telefone)


CREATE TABLE departamento_telefone(
    cd_departamento_telefone int NOT NULL,
	cd_telefone              int NOT NULL,
    cd_departamento          int NOT NULL,	    
	PRIMARY KEY (cd_departamento_telefone)	
)
ALTER TABLE departamento_telefone  WITH CHECK ADD CONSTRAINT fk_departamento_telefone_1 FOREIGN KEY(cd_departamento) REFERENCES departamento (cd_departamento)
ALTER TABLE departamento_telefone  WITH CHECK ADD CONSTRAINT fk_departamento_telefone_2 FOREIGN KEY(cd_telefone) REFERENCES telefone (cd_telefone)


CREATE TABLE tipo_documento(
	cd_tipo_documento int NOT NULL,	    
	ds_tipo_documento nvarchar(20) NOT NULL,		
	PRIMARY KEY (cd_tipo_documento)
)

CREATE TABLE documento(
	cd_documento      int NOT NULL,		
	nr_documento      nvarchar(20) NOT NULL,	
	cd_tipo_documento int NOT NULL,	    
	PRIMARY KEY (cd_documento)
)
ALTER TABLE documento  WITH CHECK ADD CONSTRAINT fk_tipo_documento FOREIGN KEY(cd_tipo_documento) REFERENCES tipo_documento (cd_tipo_documento)


CREATE TABLE usuario_documento(
    cd_usuario_documento int NOT NULL,
	cd_usuario           int NOT NULL,
    cd_documento         int NOT NULL,	    
	PRIMARY KEY (cd_usuario_documento)	
)
ALTER TABLE usuario_documento  WITH CHECK ADD CONSTRAINT fk_usuario_documento_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_documento  WITH CHECK ADD CONSTRAINT fk_usuario_documento_2 FOREIGN KEY(cd_documento) REFERENCES documento (cd_documento)


CREATE TABLE departamento_documento(
    cd_departamento_documento int NOT NULL,
	cd_departamento           int NOT NULL,
    cd_documento              int NOT NULL,	    
	PRIMARY KEY (cd_departamento_documento)	
)
ALTER TABLE departamento_documento  WITH CHECK ADD CONSTRAINT fk_departamento_documento_1 FOREIGN KEY(cd_departamento) REFERENCES departamento (cd_departamento)
ALTER TABLE departamento_documento  WITH CHECK ADD CONSTRAINT fk_departamento_documento_2 FOREIGN KEY(cd_documento) REFERENCES documento (cd_documento)



CREATE TABLE aeronave_documento(
    cd_aeronave_documento int NOT NULL,
	cd_aeronave           int NOT NULL,
    cd_documento          int NOT NULL,	    
	PRIMARY KEY (cd_aeronave_documento)	
)
ALTER TABLE aeronave_documento  WITH CHECK ADD CONSTRAINT fk_aeronave_documento_1 FOREIGN KEY(cd_aeronave) REFERENCES aeronave (cd_aeronave)
ALTER TABLE aeronave_documento  WITH CHECK ADD CONSTRAINT fk_aeronave_documento_2 FOREIGN KEY(cd_documento) REFERENCES documento (cd_documento)


CREATE TABLE tipo_endereco(	
	cd_tipo_endereco int NOT NULL,		
	ds_tipo_endereco nvarchar(20),	
	PRIMARY KEY (cd_tipo_endereco)
)

CREATE TABLE endereco(
	cd_endereco        int NOT NULL,			
	nr_cep             nvarchar(10) NOT NULL,	
	ds_logradouro      nvarchar(20) NOT NULL,	
	ds_endereco        nvarchar(50),
	nr_numero          varchar(5),
	ds_complemento     nvarchar(50),	
	ds_geo_localizacao nvarchar(20) NOT NULL,
	cd_tipo_endereco   int NOT NULL,
	cd_cidade          int NOT NULL,	
	PRIMARY KEY (cd_endereco)
)
ALTER TABLE endereco  WITH CHECK ADD CONSTRAINT fk_endereco_tipo_endereco_1 FOREIGN KEY(cd_tipo_endereco) REFERENCES tipo_endereco (cd_tipo_endereco)
ALTER TABLE endereco  WITH CHECK ADD CONSTRAINT fk_endereco_cidade_1 FOREIGN KEY(cd_cidade) REFERENCES cidade (cd_cidade)


CREATE TABLE usuario_endereco(
    cd_usuario_endereco int NOT NULL,
	cd_usuario          int NOT NULL,
    cd_endereco         int NOT NULL,	    
	PRIMARY KEY (cd_usuario_endereco)	
)
ALTER TABLE usuario_endereco  WITH CHECK ADD CONSTRAINT fk_usuario_endereco_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_endereco  WITH CHECK ADD CONSTRAINT fk_usuario_endereco_2 FOREIGN KEY(cd_endereco) REFERENCES endereco (cd_endereco)


CREATE TABLE departamento_endereco(
    cd_departamento_endereco int NOT NULL,
	cd_departamento          int NOT NULL,
    cd_endereco             int NOT NULL,	    
	PRIMARY KEY (cd_departamento_endereco)	
)
ALTER TABLE departamento_endereco  WITH CHECK ADD CONSTRAINT fk_departamento_endereco_1 FOREIGN KEY(cd_departamento) REFERENCES departamento (cd_departamento)
ALTER TABLE departamento_endereco  WITH CHECK ADD CONSTRAINT fk_departamento_endereco_2 FOREIGN KEY(cd_endereco) REFERENCES endereco (cd_endereco)


CREATE TABLE arquivo(
    cd_arquivo int NOT NULL,
	tp_arquivo nvarchar(5),	
	nm_arquivo nvarchar(50),
	ds_arquivo nvarchar(100), 	
	im_arquivo varbinary(max),
	PRIMARY KEY (cd_arquivo)	
)

CREATE TABLE usuario_arquivo(
    cd_usuario_arquivo int NOT NULL,
	cd_usuario         int NOT NULL,
    cd_arquivo         int NOT NULL,	    
	PRIMARY KEY (cd_usuario_arquivo)	
)
ALTER TABLE usuario_arquivo  WITH CHECK ADD CONSTRAINT fk_usuario_arquivo_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_arquivo  WITH CHECK ADD CONSTRAINT fk_usuario_arquivo_2 FOREIGN KEY(cd_arquivo) REFERENCES arquivo (cd_arquivo)


CREATE TABLE documento_arquivo(
    cd_documento_arquivo int NOT NULL,
	cd_documento         int NOT NULL,
    cd_arquivo           int NOT NULL,	    
	PRIMARY KEY (cd_documento_arquivo)	
)
ALTER TABLE documento_arquivo  WITH CHECK ADD CONSTRAINT fk_documento_arquivo_1 FOREIGN KEY(cd_documento) REFERENCES documento (cd_documento)
ALTER TABLE documento_arquivo  WITH CHECK ADD CONSTRAINT fk_documento_arquivo_2 FOREIGN KEY(cd_arquivo) REFERENCES arquivo (cd_arquivo)


CREATE TABLE departamento_arquivo(
    cd_departamento_arquivo int NOT NULL,
	cd_departamento         int NOT NULL,
    cd_arquivo             int NOT NULL,	    
	PRIMARY KEY (cd_departamento_arquivo)	
)
ALTER TABLE departamento_arquivo  WITH CHECK ADD CONSTRAINT fk_departamento_arquivo_1 FOREIGN KEY(cd_departamento) REFERENCES departamento (cd_departamento)
ALTER TABLE departamento_arquivo  WITH CHECK ADD CONSTRAINT fk_departamento_arquivo_2 FOREIGN KEY(cd_arquivo) REFERENCES arquivo (cd_arquivo)


CREATE TABLE aeronave_arquivo(
    cd_aeronave_arquivo int NOT NULL,
	cd_aeronave         int NOT NULL,
    cd_arquivo          int NOT NULL,	    
	PRIMARY KEY (cd_aeronave_arquivo)	
)
ALTER TABLE aeronave_arquivo  WITH CHECK ADD CONSTRAINT fk_aeronave_arquivo_1 FOREIGN KEY(cd_aeronave) REFERENCES aeronave (cd_aeronave)
ALTER TABLE aeronave_arquivo  WITH CHECK ADD CONSTRAINT fk_aeronave_arquivo_2 FOREIGN KEY(cd_arquivo) REFERENCES arquivo (cd_arquivo)



CREATE TABLE email(
    cd_email int NOT NULL,
	ds_email nvarchar(50) NOT NULL,	    
	PRIMARY KEY (cd_email)	
)

CREATE TABLE usuario_email(
    cd_usuario_email int NOT NULL,
	cd_usuario           int NOT NULL,
    cd_email         int NOT NULL,	    
	PRIMARY KEY (cd_usuario_email)	
)
ALTER TABLE usuario_email  WITH CHECK ADD CONSTRAINT fk_usuario_email_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_email  WITH CHECK ADD CONSTRAINT fk_usuario_email_2 FOREIGN KEY(cd_email) REFERENCES email (cd_email)

CREATE TABLE departamento_email(
    cd_departamento_email int NOT NULL,
	cd_departamento         int NOT NULL,
    cd_email             int NOT NULL,	    
	PRIMARY KEY (cd_departamento_email)	
)
ALTER TABLE departamento_email  WITH CHECK ADD CONSTRAINT fk_departamento_email_1 FOREIGN KEY(cd_departamento) REFERENCES departamento (cd_departamento)
ALTER TABLE departamento_email  WITH CHECK ADD CONSTRAINT fk_departamento_email_2 FOREIGN KEY(cd_email) REFERENCES email (cd_email)


CREATE TABLE agenda(
    cd_agenda       int NOT NULL,
	nr_agenda       int NOT NULL,
	nr_ano          int NOT NULL,	
	PRIMARY KEY (cd_agenda)	
)

CREATE TABLE reserva(
    cd_reserva       int NOT NULL,
	nr_reserva       nvarchar(20),		
	dt_agenda        datetime  NOT NULL,		
	dt_resernva      datetime  NOT NULL,		
	hr_reserva_ini   datetime NOT NULL,
	hr_reserva_fin   datetime NOT NULL,	
	PRIMARY KEY (cd_reserva) 	
)

CREATE TABLE agenda_reserva(  
    cd_agenda_reserva  int NOT NULL,	
    cd_reserva       int NOT NULL,	
	cd_agenda        int NOT NULL,
	PRIMARY KEY (cd_agenda_reserva) 	
)
ALTER TABLE agenda_reserva  WITH CHECK ADD CONSTRAINT fk_agenda_reserva_1 FOREIGN KEY(cd_agenda) REFERENCES agenda (cd_agenda)
ALTER TABLE agenda_reserva  WITH CHECK ADD CONSTRAINT fk_agenda_reserva_2 FOREIGN KEY(cd_reserva) REFERENCES reserva (cd_reserva)


CREATE TABLE usuario_agenda_reserva(    
	cd_usuario        int NOT NULL,			
	cd_agenda_reserva int NOT NULL,
	PRIMARY KEY (cd_usuario, cd_agenda_reserva) 	
)
ALTER TABLE usuario_agenda_reserva  WITH CHECK ADD CONSTRAINT fk_usuario_agenda_reserva_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_agenda_reserva  WITH CHECK ADD CONSTRAINT fk_usuario_agenda_reserva_2 FOREIGN KEY(cd_agenda_reserva) REFERENCES agenda_reserva (cd_agenda_reserva)


CREATE TABLE departamento_agenda_reserva(    
	cd_departamento   int NOT NULL,			
	cd_agenda_reserva int NOT NULL,
	PRIMARY KEY (cd_departamento, cd_agenda_reserva) 	
)
ALTER TABLE departamento_agenda_reserva  WITH CHECK ADD CONSTRAINT fk_departamento_agenda_reserva_1 FOREIGN KEY(cd_departamento) REFERENCES departamento (cd_departamento)
ALTER TABLE departamento_agenda_reserva  WITH CHECK ADD CONSTRAINT fk_departamento_agenda_reserva_2 FOREIGN KEY(cd_agenda_reserva) REFERENCES agenda_reserva (cd_agenda_reserva)


CREATE TABLE aeronave_agenda_reserva(    
	cd_aeronave       int NOT NULL,			
	cd_agenda_reserva int NOT NULL,
	PRIMARY KEY (cd_aeronave, cd_agenda_reserva) 	
)
ALTER TABLE aeronave_agenda_reserva  WITH CHECK ADD CONSTRAINT fkaeronave_agenda_reserva_1 FOREIGN KEY(cd_aeronave) REFERENCES aeronave (cd_aeronave)
ALTER TABLE aeronave_agenda_reserva  WITH CHECK ADD CONSTRAINT fk_aeronave_agenda_reserva_2 FOREIGN KEY(cd_agenda_reserva) REFERENCES agenda_reserva (cd_agenda_reserva)


CREATE TABLE tipo_curso(
	cd_tipo_curso int NOT NULL,	
	ds_tipo_curso nvarchar(50) NOT NULL,
	PRIMARY KEY (cd_tipo_curso)	
)
CREATE TABLE curso(
	cd_curso      int NOT NULL,		
	fl_ativo      char(1) NOT NULL DEFAULT 'S',	
	nm_curso      nvarchar(50) NOT NULL,
	cd_tipo_curso int NOT NULL,			
	PRIMARY KEY (cd_curso)	
)
ALTER TABLE curso  WITH CHECK ADD CONSTRAINT fk_tipo_curso FOREIGN KEY(cd_tipo_curso) REFERENCES tipo_curso (cd_tipo_curso)

CREATE TABLE curso_detalhe(
	cd_curso_detalhe int NOT NULL,	
	ds_curso_detalhe int NOT NULL,	
	dt_ini           datetime NOT NULL,	
	dt_fin           datetime NOT NULL,	
	tx_desconto      numeric(15,2) NOT NULL,	
	vl_desconto      numeric(15,2) NOT NULL,	
	vl_curso         numeric(15,2) NOT NULL,		
	PRIMARY KEY (cd_curso_detalhe)	
)
ALTER TABLE curso  WITH CHECK ADD CONSTRAINT fk_tipo_cursocurso FOREIGN KEY(cd_tipo_curso) REFERENCES tipo_curso (cd_tipo_curso)


CREATE TABLE tipo_disciplina(
	cd_tipo_disciplina int NOT NULL,	
	ds_tipo_disciplina nvarchar(50) NOT NULL,
	PRIMARY KEY (cd_tipo_disciplina)	
)


CREATE TABLE disciplina(
	cd_disciplina      int NOT NULL,		
	fl_ativo      char(1) NOT NULL DEFAULT 'S',	
	nm_disciplina      nvarchar(50) NOT NULL,
	ds_disciplina      nvarchar(50) NOT NULL,
	cd_tipo_disciplina int NOT NULL,			
	PRIMARY KEY (cd_disciplina)	
)
ALTER TABLE disciplina  WITH CHECK ADD CONSTRAINT fk_tipo_disciplina FOREIGN KEY(cd_tipo_disciplina) REFERENCES tipo_disciplina (cd_tipo_disciplina)


CREATE TABLE disciplina_curso(
    cd_disciplina_curso  int NOT NULL,
	cd_curso   int NOT NULL,
	cd_disciplina      int NOT NULL,	
	PRIMARY KEY (cd_disciplina_curso)	
)
ALTER TABLE disciplina_curso  WITH CHECK ADD CONSTRAINT fk_disciplina_curso_1 FOREIGN KEY(cd_disciplina) REFERENCES disciplina (cd_disciplina)
ALTER TABLE disciplina_curso  WITH CHECK ADD CONSTRAINT fk_disciplina_curso_2 FOREIGN KEY(cd_curso) REFERENCES curso (cd_curso)


CREATE TABLE disciplina_instrutor(
    cd_disciplina_instrutor int NOT NULL,	
	cd_disciplina      int NOT NULL,	
	cd_usuario   int NOT NULL,
	PRIMARY KEY (cd_disciplina_instrutor)	
)
ALTER TABLE disciplina_instrutor  WITH CHECK ADD CONSTRAINT fk_disciplina_instrutor_1 FOREIGN KEY(cd_disciplina) REFERENCES disciplina (cd_disciplina)
ALTER TABLE disciplina_instrutor  WITH CHECK ADD CONSTRAINT fk_disciplina_instrutor_2 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)


CREATE TABLE disciplina_aluno(
    cd_disciplina_aluno int NOT NULL,	
	cd_disciplina      int NOT NULL,	
	cd_usuario   int NOT NULL,
	PRIMARY KEY (cd_disciplina_aluno)	
)
ALTER TABLE disciplina_aluno  WITH CHECK ADD CONSTRAINT fk_disciplina_aluno_1 FOREIGN KEY(cd_disciplina) REFERENCES disciplina (cd_disciplina)
ALTER TABLE disciplina_aluno  WITH CHECK ADD CONSTRAINT fk_disciplina_aluno_2 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)


CREATE TABLE grade(
    cd_grade           int NOT NULL,
	ds_grade           nvarchar(50) NOT NULL,
	cd_curso_detalhe   int NOT NULL,			
	PRIMARY KEY (cd_grade)	
)
ALTER TABLE grade  WITH CHECK ADD CONSTRAINT fk_curso_detalhe FOREIGN KEY(cd_curso_detalhe) REFERENCES curso_detalhe (cd_curso_detalhe)



CREATE TABLE grade_reserva(
    grade_reserva int NOT NULL,
    cd_grade      int NOT NULL,
	cd_reserva    int NOT NULL,
	PRIMARY KEY (cd_grade)	
)
ALTER TABLE grade_reserva  WITH CHECK ADD CONSTRAINT fk_grade_reserva_1 FOREIGN KEY(cd_grade) REFERENCES grade (cd_grade)
ALTER TABLE grade_reserva  WITH CHECK ADD CONSTRAINT fk_grade_reserva_2 FOREIGN KEY(cd_reserva) REFERENCES reserva (cd_reserva)



CREATE TABLE usuario_prestacao(
    cd_prestacao     int NOT NULL,	
	ds_prestacao     nvarchar(50) NOT NULL,	
	vl_prestacao     numeric(15,2),    
	cd_usuario       int NOT NULL,	
	cd_curso_detalhe int NOT NULL,
	PRIMARY KEY (cd_prestacao)	
)

ALTER TABLE usuario_prestacao  WITH CHECK ADD CONSTRAINT fk_usuario_prestacao_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_prestacao  WITH CHECK ADD CONSTRAINT fk_usuario_prestacao_2 FOREIGN KEY(cd_curso_detalhe) REFERENCES curso_detalhe (cd_curso_detalhe)



CREATE TABLE usuario_pagamento(
    cd_pagamento     int NOT NULL,	
	ds_pagamento     nvarchar(50) NOT NULL,		
	tx_juros         numeric(15,2),    
	vl_juros         numeric(15,2),    
	tx_desconto      numeric(15,2), 
	vl_desconto      numeric(15,2), 
	vl_pagamento     numeric(15,2), 
	cd_usuario       int NOT NULL,
	cd_prestacao     int NULL,			
	PRIMARY KEY (cd_pagamento)	
)

ALTER TABLE usuario_pagamento  WITH CHECK ADD CONSTRAINT fk_usuario_pagamento_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_pagamento  ADD CONSTRAINT fk_usuario_pagamento_2 FOREIGN KEY(cd_prestacao) REFERENCES usuario_prestacao (cd_prestacao)



CREATE TABLE usuario_recebimento(
    cd_recebimento   int NOT NULL,	
	ds_recebimento   nvarchar(50) NOT NULL,		
	tx_juros         numeric(15,2),    
	vl_juros         numeric(15,2),    
	tx_desconto      numeric(15,2), 
	vl_desconto      numeric(15,2), 
	vl_recebimento   numeric(15,2), 
	cd_usuario       int NOT NULL,
	cd_prestacao     int NOT NULL,			
	PRIMARY KEY (cd_recebimento)	
)

ALTER TABLE usuario_recebimento  WITH CHECK ADD CONSTRAINT fk_usuario_recebimento_1 FOREIGN KEY(cd_usuario) REFERENCES usuario (cd_usuario)
ALTER TABLE usuario_recebimento  WITH CHECK ADD CONSTRAINT fk_usuario_recebimento_2 FOREIGN KEY(cd_prestacao) REFERENCES usuario_prestacao (cd_prestacao)
