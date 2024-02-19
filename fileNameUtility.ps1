# Accept input from the user
$inputString = Read-Host "Enter a string (e.g., '217. Contains Duplicate')"

$scriptDirectory = Split-Path -Parent $MyInvocation.MyCommand.Definition

# Remove special characters and spaces from the input string
$cleanedString = $inputString -replace '[^\w\d]', ''

# Check if the cleaned string is not empty
if ($cleanedString -ne '') {
    # Extract the number and title
    $number = $cleanedString -replace '\D', ''
    $title = $cleanedString -replace '\d', ''

    # Format the output string
    $outputString = "LC${number}_${title}"

    # Display the manipulated string
    Write-Host "Output: $outputString"

      # Specify the relative folder for the output file
      $outputFolder = Join-Path $scriptDirectory "Algos"

      # Create the output folder if it doesn't exist
    if (-not (Test-Path $outputFolder -PathType Container)) {
        New-Item -ItemType Directory -Path $outputFolder | Out-Null
    }

    # Create a .cs file with the filename based on outputString
   # $filename = "$outputString.cs"
   $filename = Join-Path $outputFolder "$outputString.cs"

    $content = @"
// Your C# code here
public class $outputString
{
    // Your code goes here
    public void $title(){
        Console.WriteLine("****** $title *********");
    }

    public static void run_$title(){
        $outputString obj = new $outputString();
        obj.$title();
    }
}
"@
    
    $content | Out-File -FilePath $filename -Force

} else {
    Write-Host "Invalid input format. Please provide a valid input."
}
