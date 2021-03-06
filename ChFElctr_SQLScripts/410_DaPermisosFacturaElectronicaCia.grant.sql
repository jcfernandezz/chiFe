--Chile
--Factura Electr�nica
--Prop�sito. Rol que da accesos a objetos de factura electr�nica
--Requisitos. Ejecutar en la compa��a.
--24/05/11 JCF Creaci�n
--
-----------------------------------------------------------------------------------
--use [COMPA�IA]

IF DATABASE_PRINCIPAL_ID('rol_cfdigital') IS NULL
	create role rol_cfdigital;

--Objetos que usa factura electr�nica
grant select, insert, update, delete on cfdLogFacturaXML to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLLoadByPrimaryKey to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLLoadAll to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLUpdate to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLInsert to rol_cfdigital, dyngrp;
grant execute on proc_cfdLogFacturaXMLDelete to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdTransaccionesDeVenta to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdDocumentosAImprimir to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdIdDocumentos  to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdClienteDireccionesCorreo to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdCartasReclamacionDeuda to rol_cfdigital, dyngrp;
grant select on dbo.vwCfdCertificados to rol_cfdigital;

grant select, insert, update, delete on cfdLogLibroCV to rol_cfdigital;
grant execute on proc_cfdLogLibroCVLoadByPrimaryKey to rol_cfdigital;
grant execute on proc_cfdLogLibroCVLoadAll to rol_cfdigital;
grant execute on proc_cfdLogLibroCVUpdate to rol_cfdigital;
grant execute on proc_cfdLogLibroCVInsert to rol_cfdigital;
grant execute on proc_cfdLogLibroCVDelete to rol_cfdigital;
grant select on vwCfdLibroCVLog to rol_cfdigital;

grant select, insert, update, delete on cfdLogFacturaCompra to rol_cfdigital;
grant execute on proc_cfdLogFacturaCompraLoadByPrimaryKey to rol_cfdigital;
grant execute on proc_cfdLogFacturaCompraLoadAll to rol_cfdigital;
grant execute on proc_cfdLogFacturaCompraUpdate to rol_cfdigital;
grant execute on proc_cfdLogFacturaCompraInsert to rol_cfdigital;
grant execute on proc_cfdLogFacturaCompraDelete to rol_cfdigital;
grant select on vwCfdLogFacturaCompra to rol_cfdigital;
grant execute on dbo.SP_cfd_FOL00100 to rol_cfdigital;
grant select on dbo.cfd_FOL00100 to rol_cfdigital;
