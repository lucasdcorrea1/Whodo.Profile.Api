USE  "Whodo-hml"

CREATE TABLE [Profile](
	Id					BIGINT IDENTITY(1, 1) NOT NULL,
	[Name]				VARCHAR(255) NOT NULL,
	Email				VARCHAR(255) NOT NULL,
	[Password]			VARCHAR(MAX) NOT NULL,
	Cpf				    BIGINT NULL,
	Cnpj			    BIGINT NULL,
	Active			    BIT NOT NULL,
	CreationDate		DATETIME NOT NULL,
	LastUpdateDate		DATETIME NULL,
	CONSTRAINT PK_Debit PRIMARY KEY(Id),
)
GO