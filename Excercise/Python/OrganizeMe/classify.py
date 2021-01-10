import os
from pathlib import Path
# What is the diff between import and form .. import

# Remember { } and : syntax
SUBDIRECTORIES = {
    "Documents": [".pdf", ".doc", ".txt"],
    "Audio"    : [".mp3", ".wav", ".m4a"],
    "Video"    : [".mov", ".avi", ".mp4"],
    "Images"   : [".jpg", ".jpeg", ".png"]
}

def pickDirecotory(value):
    # Make a note of items method at the end.
    for Category, Extensions in SUBDIRECTORIES.items():
        for Extension in Extensions:
            if(Extension == value):
                return Category
    return "MISC"

def orgnizeDirectory():
    for item in os.scandir():
        if item.is_dir():
            continue
        filepath = Path(item)
        filetype = filepath.suffix.lower()
        directory = pickDirecotory(filetype)
        directoryPath = Path(directory)

        if directoryPath.is_dir() != True:
            directoryPath.mkdir()

        filepath.rename(directoryPath.joinpath(filepath))

orgnizeDirectory()