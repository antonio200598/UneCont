USE [unecont]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NotaFiscal](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PrestadorId] [bigint] NOT NULL,
	[TomadorId] [bigint] NOT NULL,
	[ServicoId] [bigint] NOT NULL,
	[Numero] [bigint] NOT NULL,
	[DataEmissao] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[NotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_Prestador] FOREIGN KEY([PrestadorId])
REFERENCES [dbo].[NotaFiscal_Prestador] ([Id])
GO

ALTER TABLE [dbo].[NotaFiscal] CHECK CONSTRAINT [FK_Prestador]
GO

ALTER TABLE [dbo].[NotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_Servico] FOREIGN KEY([ServicoId])
REFERENCES [dbo].[NotaFiscal_Servico] ([Id])
GO

ALTER TABLE [dbo].[NotaFiscal] CHECK CONSTRAINT [FK_Servico]
GO

ALTER TABLE [dbo].[NotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_Tomador] FOREIGN KEY([TomadorId])
REFERENCES [dbo].[NotaFiscal_Tomador] ([Id])
GO

ALTER TABLE [dbo].[NotaFiscal] CHECK CONSTRAINT [FK_Tomador]
GO

