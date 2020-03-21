DROP TABLE Cliente ;  
DROP TABLE MediosEnvio ;  
DROP TABLE MediosPago ;  
DROP TABLE Catalogo ;  
DROP TABLE Pastel ;  
DROP TABLE Administrador ; 
DROP TABLE Usuario ; 
DROP TABLE Pedido ; 
DROP TABLE Factura;
DROP TABLE MediosEnvio_Cliente;
DROP TABLE MediosPago_Cliente;


CREATE TABLE [dbo].[Usuario]
(
	    [ID_USUARIO]          INT             NOT NULL,
    [NOMBRE_USUARIO]      VARCHAR (50)    NOT NULL,
    [APELLIDO_USUARIO]       VARCHAR (50) NOT NULL,

    [CORREO_ELECTONICO_USUARIO]  VARCHAR (50)             NOT NULL,
        [CONTRASEÑA_USUARIO]  VARCHAR (50)             NOT NULL,


        PRIMARY KEY CLUSTERED ([ID_USUARIO] ASC)

);

CREATE TABLE [dbo].[Administrador]
(
	   [ID_ADMINISTRADOR]          INT             NOT NULL,
    [AREA_ADMINISTRADOR] VARCHAR (50)            NOT NULL,
   PRIMARY KEY CLUSTERED ([ID_ADMINISTRADOR] ASC),
           FOREIGN KEY ([ID_ADMINISTRADOR]) REFERENCES [dbo].[Usuario] ([ID_USUARIO])


);

CREATE TABLE [dbo].[Cliente]
(
	   [ID_CLIENTE]          INT             NOT NULL,
    [DIRECCION_CLIENTE] VARCHAR (50)            NOT NULL,
    [CIUDAD_CLIENTE]      VARCHAR (50) NOT NULL,
    [DEPARTAMENTO_CLIENTE] VARCHAR (50)    NOT NULL,
    [TELEFONO_CLIENTE]      INT           NOT NULL,
            PRIMARY KEY CLUSTERED ([ID_CLIENTE] ASC),

           FOREIGN KEY ([ID_CLIENTE]) REFERENCES [dbo].[Usuario] ([ID_USUARIO])

);

CREATE TABLE [dbo].[MediosEnvio]
(
	    [ID_MEDIOSENVIOS]          INT             NOT NULL,
    [NOMBRE_MEDIOSENVIOS]      VARCHAR (50)    NOT NULL,
    [DESCRIPCION_MEDIOSENVIOS]      VARCHAR (250)    NOT NULL,

        PRIMARY KEY CLUSTERED ([ID_MEDIOSENVIOS] ASC)

);
CREATE TABLE [dbo].[MediosPago]
(
	    [ID_MEDIOSPAGO]          INT             NOT NULL,
    [NOMBRE_MEDIOSPAGO]      VARCHAR (50)    NOT NULL,
      [DESCRIPCION_MEDIOSPAGO]      VARCHAR (250)    NOT NULL,


        PRIMARY KEY CLUSTERED ([ID_MEDIOSPAGO] ASC)

);
CREATE TABLE [dbo].[Catalogo] (
    [ID_CATALOGO]     INT          NOT NULL,
    [NOMBRE_CATALOGO] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_CATALOGO] ASC)
); 

CREATE TABLE [dbo].[Pastel] (
    [ID_PASTEL]          INT             NOT NULL,
    [NOMBRE_PASTEL]      VARCHAR (50)    NOT NULL,
    [PESO_PASTEL]        NUMERIC (18, 2) NOT NULL,
    [IDCATEGORIA_PASTEL] INT             NOT NULL,
    [PRECIO_PASTEL]      NUMERIC (18, 2) NOT NULL,
    [DESCRIPCION_PASTEL] VARCHAR (250)    NOT NULL,
    [IMAGEN_PASTEL]      IMAGE           NULL,
    [ID_CATALOGO]  INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_PASTEL] ASC),
    FOREIGN KEY ([ID_CATALOGO]) REFERENCES [dbo].[Catalogo] ([ID_CATALOGO])
);
CREATE TABLE [dbo].[Pedido] (
    [ID_PEDIDO]          INT             NOT NULL,
[ID_CLIENTE]          INT             NOT NULL,
[ID_PASTEL]          INT             NOT NULL,
    [CANTIDAD]        NUMERIC (18, 0) NOT NULL,
    [TOTAL]  NUMERIC (18, 0)    NULL,
    PRIMARY KEY CLUSTERED ([ID_PEDIDO] ASC),
    FOREIGN KEY ([ID_PASTEL]) REFERENCES [dbo].[Pastel] ([ID_PASTEL]),
        FOREIGN KEY ([ID_CLIENTE]) REFERENCES [dbo].[Cliente] ([ID_CLIENTE])

);

CREATE TABLE [dbo].[Factura] (
    [ID_FACTURA]          INT             NOT NULL,
    [ID_PEDIDO]          INT             NOT NULL,
    [URL_FACTURA]         VARCHAR (250) NOT NULL,
   
    PRIMARY KEY CLUSTERED ([ID_FACTURA] ASC),
    FOREIGN KEY ([ID_PEDIDO]) REFERENCES [dbo].[Pedido] ([ID_PEDIDO])
);
CREATE TABLE [dbo].[MediosPago_Cliente] (
    [ID_CLIENTE]          INT             NOT NULL,
    [ID_MEDIOSPAGO]          INT             NOT NULL,
   
       FOREIGN KEY ([ID_CLIENTE]) REFERENCES [dbo].[Cliente] ([ID_CLIENTE]),

   
    FOREIGN KEY ([ID_MEDIOSPAGO]) REFERENCES [dbo].[MediosPago] ([ID_MEDIOSPAGO])
);
CREATE TABLE [dbo].[MediosEnvio_Cliente] (
    [ID_CLIENTE]          INT             NOT NULL,
    [ID_MEDIOSENVIOS]          INT             NOT NULL,
    FOREIGN KEY ([ID_CLIENTE]) REFERENCES [dbo].[Cliente] ([ID_CLIENTE]),

    FOREIGN KEY ([ID_MEDIOSENVIOS]) REFERENCES [dbo].[MediosEnvio] ([ID_MEDIOSENVIOS])
);
