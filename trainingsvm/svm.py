import numpy as np
import cv2 as cv
import pandas as pd
import pickle

featureData = pd.read_csv('FeatureVector.txt', sep=" ", header=None, usecols = range(20))

#dividing the data into attributes and labels
X = featureData #attribute
#temp = featureData.drop(columns=["20"])
#y = label #label

label = []
for i in featureData.index:
    if i<1200:
        label.append(1)
    elif i<2400:
        label.append(2)
    elif i<3600:
        label.append(3)

y = label

#seamlessly divide data into training and testing sets
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.20)

#training the algorithm
from sklearn.svm import SVC
svclassifier = SVC(kernel='linear')
svclassifier.fit(X_train, y_train)

#save model
filename = 'finalized_model.sav'
pickle.dump(svclassifier, open(filename, 'wb'))

#load the model
model = pickle.load(open(filename, 'rb'))

y_pred = model.predict(X_test)

#makeing predictions
#y_pred = svclassifier.predict(X_test)

#evaluate the algorithm
from sklearn.metrics import classification_report, confusion_matrix
print(confusion_matrix(y_test, y_pred))
print(classification_report(y_test, y_pred))