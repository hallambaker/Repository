setlocal
cd %~dp0
set Root=../..
set DocSource=../Word
rem set DocSource=O:\Documents\Mesh

echo Generate schemas etc.
cd Generated 

protogen %Root%/Goedel.Callsign.Log/CallsignLog.protocol /md
protogen %Root%/Goedel.Callsign.Registrar/CallsignRegistrar.protocol /md
protogen %Root%/Goedel.Callsign.Registry/CallsignRegistry.protocol /md


cd ..\Publish
echo Convert documents to TXT, XML and HTML formats

copy ..\xml2rfc.css .
copy ..\xml2rfc.js .
copy ..\bib.xml .
copy ..\favicon.png .


rfctool %DocSource%\hallambaker-mesh-7-discovery.docx  /auto /cache=bib.xml

exit /b 0

