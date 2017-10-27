xcopy Chap01\QueueLib\Step0 	Demos\QueueLib\ /s /H
xcopy CaseStudy\Acme\Step0 	Labs\Lab1\ /s /H

xcopy Chap02\CSharpMax\Step3 	Demos\CSharpMax\ /s /H
xcopy Chap02\QueueSetup 	Demos\QueueSetup\ /s /H
md Labs\Lab2A
copy Labs\readme.txt 		Labs\Lab2A
xcopy CaseStudy\Acme\Step1 	Labs\Lab2B\ /s /H

xcopy Chap03\QueueLib\Step2 	Labs\Lab3A\QueueLib\ /s /H
xcopy CaseStudy\Acme\Step2 	Labs\Lab3B\ /s /H
