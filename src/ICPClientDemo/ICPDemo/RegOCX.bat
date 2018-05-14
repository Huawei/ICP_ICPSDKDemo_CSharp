for /r %%i in (*.ocx) do (
regsvr32 "%%i"
)