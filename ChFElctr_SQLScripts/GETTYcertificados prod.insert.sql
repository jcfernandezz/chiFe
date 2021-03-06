--Inserta datos de certificados de personas en producción
--

use chi10
go
--atención: los ids de usuario deben estar guardados con minúsculas incluyendo el dominio. Ejemplo: gila\priscilla.parra
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\priscilla.parra', '141475347', '5/29/17', '5/29/18', 
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\andrea.gomez', '141475347', '5/29/17', '5/29/18', 
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO

--insert into cfd_CER00100 
--( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
--	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
--values('gila\natalia.pino', '141475347', '5/29/17', '11/11/18', 
--		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
--		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
--		'1234', 1, 1, 1, 1, 1)
--GO

insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\natalia.pino', '190024784', '11/15/2018', '11/14/2021', 
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\npino\certNPino.p12',
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\npino\certNPino.p12',
		'Getty-2018', 1, 1, 1, 1, 1)
GO

insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\ext-tiiselam4', '190024784', '11/15/2018', '11/14/2021', 
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\npino\certNPino.p12',
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\npino\certNPino.p12',
		'Getty-2018', 1, 1, 1, 1, 1)
GO

insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\tiiselam', '190024784', '11/15/2018', '11/14/2021', 
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\npino\certNPino.p12',
		'\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\npino\certNPino.p12',
		'Getty-2018', 1, 1, 1, 1, 1)
GO


select *
--update c set --aca_rut = '141475347'
--			ruta_certificado = '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
--			ruta_clave =       '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.p12',
--			contrasenia_clave = '1234'
--delete c
from cfd_CER00100 c
WHERE USERID  = 'gila\tiiselam'

---------------------------------------------------------------------------------------------------------------------------
--Inserta configuración CAF (folios) por tipo de documento
---------------------------------------------------------------------------------------------------------------------------

select *
--update f set ruta_codigo_autorizacion = '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261642018321616.xml'
--delete f
from  cfd_FOL00100 f
where --f.soptype = 4
 f.docid = 'NCREDIT ELECTRN'	--'FACTURA ELCTRN'	--'FACTURA ELCTRN'	--

select max(sopnumbe) from sop30200 where soptype = 3

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(3, 'FACTURA ELCTRN', 61, 106, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII767319823361201798845.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(3, 'FACTURA ELCTRN', 343, 608, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII767319823334320171212958.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(3, 'FACTURA ELCTRN', 609, 1081, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII767319823360920182261151.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(3, 'FACTURA ELCTRN', 1082, 1925, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII767319826118220181126126.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 64, 106, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261642018321616.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 107, 176, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII76731982611072018741744.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 178, 178, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261178201811211227.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 179, 179, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261179201811211229.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 180, 180, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261180201811211231.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 181, 181, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261181201811211232.xml');

--insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
--values(4, 'NCREDIT ELECTRN', 182, 182, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII767319826118220181126126.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(4, 'NCREDIT ELECTRN', 183, 183, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261183201811281159.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(3, 'FAC ELEC EXENTA', 1, 20, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198234120177211538.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(3, 'NDEBITO ELECTRN', 1, 16, '\\GILABASRDB07\GettyCh_FacturaElectronicaCertificados\FoliosSII767319825612018718132.xml');


----------------------------------------------------------------------------------
--Ruta donde se guardan las facturas
--update s set inet7 = '\\GILABASRDB06\GettyCh_FacturaElectronicaXml\'
select * 
from SY01200 s
where s.adrscode = 'FELECTRONICA'
and master_id = 'CHI10'

----------------------------------------------------------------------------------

--update cfd_fol00100 set ruta_codigo_autorizacion = REPLACE(ruta_codigo_autorizacion, 'gilabasrap05', 'gilabasrap05')
select docid, max(sopnumbe)		--3882 no es real
from SOP30200
--where sopnumbe like '%3882'
--where soptype = 3
group by docid


select docid, max(sopnumbe)
from SOP10100
--where soptype = 3
group by docid

select f.docid, right(rtrim(gp.sopnumbe), 7) sopnumbeGP, f.num_folio_hasta FolioMáximo
from sop40200 gp
inner join cfd_FOL00100 f
	on f.docid = gp.docid
--where gp.commntid = '33'
----------------------------------------------------------------------------------------------