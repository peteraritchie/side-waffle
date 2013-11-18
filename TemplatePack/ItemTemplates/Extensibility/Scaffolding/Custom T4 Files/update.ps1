$str = ""
Get-ChildItem *.t4 -Recurse | 
    ForEach-Object { 
        $relPath = ((Resolve-Path $_.FullName -Relative).Substring(2))


        $str += ("<ProjectItem TargetFileName=""CodeTemplates\$relPath"" ReplaceParameters=""true"">$relPath</ProjectItem>
" -f $relPath)
    }

Set-Content C:\temp\scaffoldingtemp.txt -Value $str