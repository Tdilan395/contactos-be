USE [pruebamei]
GO
/****** Object:  Table [dbo].[contactos]    Script Date: 21/03/2024 11:17:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contactos](
	[id] [int] NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[telefono] [nvarchar](20) NULL,
	[direccion] [nvarchar](200) NULL,
	[company] [nvarchar](100) NULL,
	[nota] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE contactos (
    id INT PRIMARY KEY,
    nombre NVARCHAR(100),
    email NVARCHAR(100) ,
    telefono NVARCHAR(20) ,
    direccion NVARCHAR(200),
    company NVARCHAR(100),
    nota NVARCHAR(MAX)
);

-- Insertar datos de ejemplo
INSERT INTO contactos (id, nombre, email, telefono, direccion, company, nota)
VALUES
(1, 'Juan Pérez', 'juan@example.com', '123456789', 'Calle Principal 123', 'Mi Empresa', 'Cliente VIP'),
(2, 'María López', 'maria@example.com', '987654321', 'Avenida Central 456', '', '');

