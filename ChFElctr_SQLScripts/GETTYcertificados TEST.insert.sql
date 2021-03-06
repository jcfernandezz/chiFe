--Inserta datos de certificados de personas en producción
--

use chi10
go
--atención: los ids de usuario deben estar guardados con minúsculas incluyendo el dominio. Ejemplo: gila\priscilla.parra
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\priscilla.parra', '141475347', '5/29/17', '5/29/18', 
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\andrea.gomez', '141475347', '5/29/17', '5/29/18', 
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\tiiselam', '141475347', '5/29/17', '5/29/18', 
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('gila\ext-tiiselam4', '141475347', '5/29/17', '5/29/18', 
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO
insert into cfd_CER00100 
( USERID,ACA_RUT,fecha_vig_desde,fecha_vig_hasta,ruta_certificado,ruta_clave,
	contrasenia_clave,ACA_SolicitaFolio,ACA_AnulaDocumentos,ACA_EnviaDocumentos,ACA_FirmaDocumentos,ACTIVE)
values('sa', '141475347', '5/29/17', '5/29/18', 
		'\\10.1.1.22\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'\\10.1.1.22\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.VenMay18.p12',
		'GETTY123', 1, 1, 1, 1, 1)
GO

select *
--update c set aca_rut = '141475347'
--			ruta_certificado = '\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.venMay2018.p12',
--			ruta_clave = '\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\pparra\Certificado_PriscillaParra.venMay2018.p12',
--			contrasenia_clave = 'GETTY123'
from cfd_CER00100 c
--USERID  = 'gila\priscilla.parra'

---------------------------------------------------------------------------------------------------------------------------
--Inserta configuración CAF (folios) por tipo de documento
---------------------------------------------------------------------------------------------------------------------------

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(3, 'FACTURA ELCTRN', 1, 10, '\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198233120177211552.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(4, 'NCREDIT ELECTRN', 64, 106, '\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198261642018321616.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(3, 'FAC ELEC EXENTA', 1, 10, '\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198234120177211555.xml');

insert into cfd_fol00100(SOPTYPE,DOCID,num_folio_desde,num_folio_hasta,ruta_codigo_autorizacion)
values(3, 'NDEBITO ELECTRN', 1, 20, '\\GILABASRDB06\GettyCh_FacturaElectronicaCertificados\??.xml');

-----------------------------------------------
sp_statistics cfd_FOL00100 

select *
--update f set ruta_codigo_autorizacion = '\\10.1.1.22\GettyCh_FacturaElectronicaCertificados\FoliosSII7673198233120177211552.xml'
--delete f
from  cfd_FOL00100 f
where 
f.soptype = 4
and f.docid = 'NCREDIT ELECTRN'	--'FACTURA ELCTRN'	--'NCREDIT ELECTRN'

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
-----------------------------------------------------------------------------------------------------
--Ruta donde se guardan las facturas
--update s set inet7 = '\\GILABASRDB06\GettyCh_FacturaElectronicaXml\'
select * 
from SY01200 s
where s.adrscode = 'FELECTRONICA'
and master_id = 'CHI10'

