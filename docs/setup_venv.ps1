$venv= ".tox/py"

if (-Not (Test-Path -Path $venv)) {
    "Creating virtual environment $venv"
    python -m tox -- serve
}
"Entering virtual environment %venv%"
"use deactivate to leave"
& "$PSScriptRoot/$venv/Scripts/activate.ps1"
