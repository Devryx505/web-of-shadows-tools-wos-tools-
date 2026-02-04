import sys
import os

# Get the folder where the EXE or script is
base_dir = os.path.dirname(os.path.abspath(sys.argv[0]))

# Add the wos folder dynamically
sys.path.insert(0, os.path.join(base_dir, "wos"))

# Now we can import
import wos.cli as cli
from wos.cli import extract_pcpack, list_pcpack, scan_pcpack_files
